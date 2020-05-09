using gma.System.Windows;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Mausometer
{
    public partial class Form1 : Form
    {
 #region Attribute
        IO IO;
        UserActivityHook actHook;
        Point previousLocation;

        int Savetime;
        double DPI;
        
        int ClickLEFT, ClickRIGHT, ClickMIDDLE;
                int ClickLEFT_LOADED, ClickRIGHT_LOADED, ClickMIDDLE_LOADED;
        double sum; 
        double distance;
        double MWheelUP;
        double MWheelDOWN;
        int destinationDist;
        string destinationName;
        DateTime lastReset;

        bool mouseEnterflag;



        static int ScrWidth = Screen.PrimaryScreen.Bounds.Width;
        static int ScrHeight = Screen.PrimaryScreen.Bounds.Height;
        double Monitor; //Zollangabe des Monitors

#endregion

#region Initialisierung
        public Form1()
        {
            InitializeComponent();
            IO = new IO();
            actHook = new UserActivityHook(); // crate an instance with global hooks
            actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);

            previousLocation.X = Cursor.Position.X;
            previousLocation.Y = Cursor.Position.Y;

            
            //Savetimer initisalisieren Alle 15 Sekunden Daten abspeichern
            Savetime = 15*1000;
            timer1.Interval = Savetime ;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Savetimer);

            //Einstellungen und Daten laden
            try
            {
                Monitor = Convert.ToDouble(IO.load("ZOLL"));
                DPI = DPICalc(ScrWidth, ScrHeight, Monitor);
                distance = Convert.ToDouble(IO.load("distance"));
                ClickLEFT = Convert.ToInt32(IO.load("left"));
                ClickMIDDLE = Convert.ToInt32(IO.load("middle"));
                ClickRIGHT = Convert.ToInt32(IO.load("right"));
                MWheelUP = Convert.ToDouble(IO.load("up"));
                MWheelDOWN = Convert.ToDouble(IO.load("down"));
                destinationName = IO.load("destinationName");
                destinationDist = Convert.ToInt32(IO.load("destinationDist")) * 100000;  //Umrechnung km in cm
                lastReset = Convert.ToDateTime(IO.load("lastReset"));
            }
            catch (Exception e)
            {

                DialogResult result = MessageBox.Show("Fehler! Bitte Configdatei überprüfen! \n\n"  + e.ToString() );
                if (result == DialogResult.OK) Environment.Exit(0);
            }
              sum = ClickLEFT + ClickMIDDLE + ClickRIGHT;



            //Geladenen Stand abspeichern. Zur Berechnung des heutigen Erfolgs
            ClickLEFT_LOADED = ClickLEFT;
            ClickMIDDLE_LOADED = ClickMIDDLE;
            ClickRIGHT_LOADED = ClickRIGHT;

            //LastResest und Progressbar einrichten
            progressBar1.Maximum = (int)destinationDist;
            labelDestination.Text = destinationName;


            //Bei erstmaligem Programmstart Reseten
            DateTime InitialDate = new DateTime(1900, 1, 1, 0, 0, 0);
            if (DateTime.Compare(lastReset,InitialDate)==0) DataReset();

            mouseEnterflag = false;


            //Darstellung
            GUIrefresh();

        }

#endregion


#region MausMoveEvent
        public void MouseMoved(object sender, MouseEventArgs e)
        {

            // Mausbewegung registrieren
                    Point difference;
                    Point VirtualPoint = e.Location; //Virtuellen Punkt erstellen, bei dem negative Werte (-1) auf 0 gesetzt werden. Randbehandlung des Bildschirms

                    if (e.Location.X < 0) VirtualPoint.X = 0;
                    if (e.Location.Y < 0 ) VirtualPoint.Y = 0;
                    if (e.Location.Y > (ScrHeight-1)) VirtualPoint.Y = (ScrHeight - 1);
                    if (e.Location.X > (ScrWidth - 1)) VirtualPoint.X = (ScrWidth - 1);
            
             
                         difference = Point.Subtract(VirtualPoint, (Size)previousLocation);
                         previousLocation = VirtualPoint;
            
                     double distancePixels = Math.Sqrt(Math.Pow(difference.X, 2) + Math.Pow((difference.Y), 2));
                     distance += Px2Dist(distancePixels,DPI);
          
            
           


            // Klick registrieren
              if (e.Clicks > 0)
                {
                    if (e.Button.ToString() == "Left") ClickLEFT++;
                    if (e.Button.ToString() == "Middle") ClickMIDDLE++;
                    if (e.Button.ToString() == "Right") ClickRIGHT++;

                    sum = ClickLEFT + ClickMIDDLE + ClickRIGHT;

                }

            // Scrollad registrieren
                if (e.Delta > 0) //Scrollrad up
                {
                    MWheelUP++;
    
                }
                if (e.Delta < 0) //Scrollrad down
                {
                    MWheelDOWN++;
                }


            GUIrefresh();
        }

        #endregion


#region GUI
        private void GUIrefresh()
        {

            if (mouseEnterflag==true) //Darstellung der Heutigen Statistik wenn Mouse in Form1
            {
                
                labelLEFT.Text = (ClickLEFT-ClickLEFT_LOADED).ToString();
                labelMIDDLE.Text = (ClickMIDDLE-ClickMIDDLE_LOADED).ToString();
                labelRIGHT.Text = (ClickRIGHT-ClickRIGHT_LOADED).ToString();
                sum = (ClickLEFT + ClickMIDDLE + ClickRIGHT)-(ClickLEFT_LOADED+ClickMIDDLE_LOADED+ClickRIGHT_LOADED);



            }
            else
            {

                //Distanz
                double distancerounded = Math.Round(distance, 0);
                labelCM.Text = (distancerounded % 100).ToString() + " cm";
                labelM.Text = distance.ToString();
                labelM.Text = (Math.Truncate(distancerounded / 100) % 1000).ToString() + " m";
                labelKM.Text = Math.Truncate(distance / 100000).ToString() + " km";





                //Klicks
                //groupBoxClicks.Text = "Mausklicks";
                labelLEFT.Text = ClickLEFT.ToString();
                labelMIDDLE.Text = ClickMIDDLE.ToString();
                labelRIGHT.Text = ClickRIGHT.ToString();
                sum = ClickLEFT + ClickMIDDLE + ClickRIGHT;

                if (sum != 0)
                {
                    double PercLEFTClick = (ClickLEFT / sum) * 100;
                    double PercMIDDLEClick = (ClickMIDDLE / sum) * 100;
                    double PercRIGHTClick = (ClickRIGHT / sum) * 100;
                    PercLEFT.Text = Math.Round(PercLEFTClick, 1).ToString() + " %";
                    PercMIDDLE.Text = Math.Round(PercMIDDLEClick, 1).ToString() + " %";
                    PercRIGHT.Text = Math.Round(PercRIGHTClick, 1).ToString() + " %";
                }

                //Wheelrounds
                double RoundsUP = MWheelUP / 24;
                double RoundsDOWN = MWheelDOWN / 24;
                double RoundsABS = (RoundsUP + RoundsDOWN);
                labelUP.Text = Math.Truncate(RoundsUP).ToString();
                labelDOWN.Text = Math.Truncate(RoundsDOWN).ToString();
                labelABS.Text = Math.Truncate(RoundsABS).ToString();


                //Progressbar
                if ((int)Math.Truncate(distance) <= progressBar1.Maximum)
                {
                    progressBar1.Value = (int)Math.Truncate(distance);
                    Progressbarlabel.Text = Math.Round((Math.Truncate(distance) / destinationDist * 100), 2).ToString() + " %"; //Prozentale Berechnung der zurückgelegten Strecke
                }
                else
                {
                    Progressbarlabel.Text = "++++ Ziel erreicht ++++";
                    Progressbarlabel.ForeColor = Color.DarkRed;

                }

                //Reset
                LastResetlabel.Text = "Letzter Reset am: " + lastReset.ToString();
            }
        }

#endregion

#region Speichern
        //Savetimer zum Speichern der Daten
        private void Savetimer(object sender, EventArgs e)
        {
            save();
        }


        private void save()
        {

            IO.save("distance", distance.ToString());
            IO.save("left", ClickLEFT.ToString());
            IO.save("middle", ClickMIDDLE.ToString());
            IO.save("right", ClickRIGHT.ToString());
            IO.save("up", MWheelUP.ToString());
            IO.save("down", MWheelDOWN.ToString());
            IO.save("lastReset", lastReset.ToString());
        }

#endregion

#region Umrechnungsfunktionen

        private double Px2Dist(double Pix, double DPI) //Umrechnen von Pixeldistanz in metrische Distanz (cm)
        {
            
            Double Dist = Pix / DPI * 2.54;
            return Dist;
        }

        private double DPICalc(int ScrWidth, int ScrHeight, double Monitor)  //DPI berechnen
        {

            DPI = Math.Sqrt(Math.Pow((double)ScrWidth, 2)+Math.Pow((double)ScrHeight, 2))/Monitor;

            return DPI;
        }
        #endregion


#region Reset
        private void LastResetlabel_Click(object sender, EventArgs e)
        {
         DialogResult result = MessageBox.Show("Möchten Sie wirklich alle aufgezeichneten Daten resetten?", "Daten löschen?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) DataReset();
        }



        private void DataReset()
        {

            distance = 0;
            ClickLEFT = 0;
            ClickMIDDLE = 0;
            ClickRIGHT = 0;
            MWheelDOWN = 0;
            MWheelUP = 0;
            lastReset = DateTime.Now;

            save();

            LastResetlabel.Text = "Letzter Reset am: " + lastReset.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        #endregion

        #region MausEnterEvents: Heutige Statistik
        //Darstellung der heutigen Satistik +++In ARBEIT ++++

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           //mouseEnterflag = true;
          // groupBoxClicks.Text = "Heutige Mausklicks"; //Groupbox wird nicht in GUI Methode umgeändert, da sonst flackern im Label entsteht!
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
          //  bool mouseEnterflag = false;
            //groupBoxClicks.Text = "Mausklicks";
        }

        

        #endregion

        #region SystemtrayIcon
        private void Form1_SizeChanged(object sender, EventArgs e)  //Bei Minimierung in Systemtray
        {
            bool MousePointerNotOnTaskBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskBar)
            {

                notifyIcon1.Icon = this.Icon;
                notifyIcon1.BalloonTipText = "Maus-O-Meter bedindet sich nun im System Tray";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Maus-O-Meter";
            }
        }

       


        private void notifyIcon1_MouseClick_1(object sender, MouseEventArgs e)  //Reaktivierung aus Systemtray
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
#endregion

    }

      
}

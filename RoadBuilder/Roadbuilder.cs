using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Roadbuilder
{
    sealed public partial class Roadbuilder : Form
    {

        private static int FRAME_LIMIT = 75;

        private int frames = 0; //Anzahl Bilder pro Sekunde
        private int updateLoopRuns = 0; //Anzahl der Updateschleifendurchläufe

        public Roadbuilder()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        public void GameLoop()
        { 
            long startTime = DateTime.Now.Ticks; //Startzeit
            long updateLoopStartTime = DateTime.Now.Ticks; //Startzeit der Updateschleife
            double maxReachableFps = 1000 / FRAME_LIMIT; //Delta zwischen den Durchläufen. Zurückgerechnet, ergibt dies die Anzahl an durchläufen der Updateschleife pro Sekunde in gleichgroßen Zeitabständen

            OnLoad();

            while (this.Created)
            {
                frames++; //Bilder pro Sekunde

                if (this.WindowState != FormWindowState.Minimized) //Falls nicht Minimiert
                {
                    TimeSpan deltaUpdate = new TimeSpan(DateTime.Now.Ticks - updateLoopStartTime);

                    if (deltaUpdate.Milliseconds >= maxReachableFps) //Bewirkt eine Limitierte Bilder pro Sekunde anzahl
                    {
                        updateLoopStartTime = DateTime.Now.Ticks;

                        OnUpdate();

                        updateLoopRuns++;
                    }

                    TimeSpan deltaFpsCounter = new TimeSpan(DateTime.Now.Ticks - startTime);

                    if (deltaFpsCounter.Seconds >= 1) //Falls der Zeitunterschied größer als eine Sekunde ist, sollen die Bilder pro Sekunde etc. Aktualisiert werden
                    {
                        startTime = DateTime.Now.Ticks;
                        this.Text = frames.ToString();
                        updateLoopRuns = 0;
                        frames = 0;
                    }
                }

                Application.DoEvents(); //Events werden abgearbeitet. Ohne diesen Befehl aufgrund von Dauerschleife keine Abarbeitung
                this.Invalidate(); //Neuzeichnen der Form wird ausgelöst
            }
        }



        private void Roadbuilder_Paint(object sender, PaintEventArgs e)
        {
            OnRender(e);
        }

        private void Roadbuilder_KeyUp(object sender, KeyEventArgs e)
        {
            OnInput(KeyPressType.KEYUP, e);
        }

        private void Roadbuilder_KeyDown(object sender, KeyEventArgs e)
        {
            OnInput(KeyPressType.KEYDOWN, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GAME
{
    public partial class Form1 : Form
    {
        #region GRAFIKA - DANE
        List<Bitmap> snowball = new List<Bitmap>();

        List<Bitmap> Idle = new List<Bitmap>();
        Bitmap Idle1 = new Bitmap(@"GRAFIKA\SANTA\Idle (1).png");
        Bitmap Idle2 = new Bitmap(@"GRAFIKA\SANTA\Idle (2).png");
        Bitmap Idle3 = new Bitmap(@"GRAFIKA\SANTA\Idle (3).png");
        Bitmap Idle4 = new Bitmap(@"GRAFIKA\SANTA\Idle (4).png");
        Bitmap Idle5 = new Bitmap(@"GRAFIKA\SANTA\Idle (5).png");
        Bitmap Idle6 = new Bitmap(@"GRAFIKA\SANTA\Idle (6).png");
        Bitmap Idle7 = new Bitmap(@"GRAFIKA\SANTA\Idle (7).png");
        Bitmap Idle8 = new Bitmap(@"GRAFIKA\SANTA\Idle (8).png");
        Bitmap Idle9 = new Bitmap(@"GRAFIKA\SANTA\Idle (9).png");
        Bitmap Idle10 = new Bitmap(@"GRAFIKA\SANTA\Idle (10).png");
        Bitmap Idle11 = new Bitmap(@"GRAFIKA\SANTA\Idle (11).png");
        Bitmap Idle12 = new Bitmap(@"GRAFIKA\SANTA\Idle (12).png");
        Bitmap Idle13 = new Bitmap(@"GRAFIKA\SANTA\Idle (13).png");
        Bitmap Idle14 = new Bitmap(@"GRAFIKA\SANTA\Idle (14).png");
        Bitmap Idle15 = new Bitmap(@"GRAFIKA\SANTA\Idle (15).png");
        Bitmap Idle16 = new Bitmap(@"GRAFIKA\SANTA\Idle (16).png");

        List<Bitmap> Dead = new List<Bitmap>();
        Bitmap Dead1 = new Bitmap(@"GRAFIKA\SANTA\Dead (1).png");
        Bitmap Dead2 = new Bitmap(@"GRAFIKA\SANTA\Dead (2).png");
        Bitmap Dead3 = new Bitmap(@"GRAFIKA\SANTA\Dead (3).png");
        Bitmap Dead4 = new Bitmap(@"GRAFIKA\SANTA\Dead (4).png");
        Bitmap Dead5 = new Bitmap(@"GRAFIKA\SANTA\Dead (5).png");
        Bitmap Dead6 = new Bitmap(@"GRAFIKA\SANTA\Dead (6).png");
        Bitmap Dead7 = new Bitmap(@"GRAFIKA\SANTA\Dead (7).png");
        Bitmap Dead8 = new Bitmap(@"GRAFIKA\SANTA\Dead (8).png");
        Bitmap Dead9 = new Bitmap(@"GRAFIKA\SANTA\Dead (9).png");
        Bitmap Dead10 = new Bitmap(@"GRAFIKA\SANTA\Dead (10).png");
        Bitmap Dead11 = new Bitmap(@"GRAFIKA\SANTA\Dead (11).png");
        Bitmap Dead12 = new Bitmap(@"GRAFIKA\SANTA\Dead (12).png");
        Bitmap Dead13 = new Bitmap(@"GRAFIKA\SANTA\Dead (13).png");
        Bitmap Dead14 = new Bitmap(@"GRAFIKA\SANTA\Dead (14).png");
        Bitmap Dead15 = new Bitmap(@"GRAFIKA\SANTA\Dead (15).png");
        Bitmap Dead16 = new Bitmap(@"GRAFIKA\SANTA\Dead (16).png");
        Bitmap Dead17 = new Bitmap(@"GRAFIKA\SANTA\Dead (17).png");

        List<Bitmap> Run = new List<Bitmap>();
        Bitmap Run1 = new Bitmap(@"GRAFIKA\SANTA\Run (1).png");
        Bitmap Run2 = new Bitmap(@"GRAFIKA\SANTA\Run (2).png");
        Bitmap Run3 = new Bitmap(@"GRAFIKA\SANTA\Run (3).png");
        Bitmap Run4 = new Bitmap(@"GRAFIKA\SANTA\Run (4).png");
        Bitmap Run5 = new Bitmap(@"GRAFIKA\SANTA\Run (5).png");
        Bitmap Run6 = new Bitmap(@"GRAFIKA\SANTA\Run (6).png");
        Bitmap Run7 = new Bitmap(@"GRAFIKA\SANTA\Run (7).png");
        Bitmap Run8 = new Bitmap(@"GRAFIKA\SANTA\Run (8).png");
        Bitmap Run9 = new Bitmap(@"GRAFIKA\SANTA\Run (9).png");
        Bitmap Run10 = new Bitmap(@"GRAFIKA\SANTA\Run (10).png");
        Bitmap Run11 = new Bitmap(@"GRAFIKA\SANTA\Run (11).png");

        List<Bitmap> Walk = new List<Bitmap>();
        Bitmap Walk1 = new Bitmap(@"GRAFIKA\SANTA\Walk (1).png");
        Bitmap Walk2 = new Bitmap(@"GRAFIKA\SANTA\Walk (2).png");
        Bitmap Walk3 = new Bitmap(@"GRAFIKA\SANTA\Walk (3).png");
        Bitmap Walk4 = new Bitmap(@"GRAFIKA\SANTA\Walk (4).png");
        Bitmap Walk5 = new Bitmap(@"GRAFIKA\SANTA\Walk (5).png");
        Bitmap Walk6 = new Bitmap(@"GRAFIKA\SANTA\Walk (6).png");
        Bitmap Walk7 = new Bitmap(@"GRAFIKA\SANTA\Walk (7).png");
        Bitmap Walk8 = new Bitmap(@"GRAFIKA\SANTA\Walk (8).png");
        Bitmap Walk9 = new Bitmap(@"GRAFIKA\SANTA\Walk (9).png");
        Bitmap Walk10 = new Bitmap(@"GRAFIKA\SANTA\Walk (10).png");
        Bitmap Walk11 = new Bitmap(@"GRAFIKA\SANTA\Walk (11).png");
        Bitmap Walk12 = new Bitmap(@"GRAFIKA\SANTA\Walk (12).png");
        Bitmap Walk13 = new Bitmap(@"GRAFIKA\SANTA\Walk (13).png");

        List<Bitmap> Jump = new List<Bitmap>();
        Bitmap Jump1 = new Bitmap(@"GRAFIKA\SANTA\Jump (1).png");
        Bitmap Jump2 = new Bitmap(@"GRAFIKA\SANTA\Jump (2).png");
        Bitmap Jump3 = new Bitmap(@"GRAFIKA\SANTA\Jump (3).png");
        Bitmap Jump4 = new Bitmap(@"GRAFIKA\SANTA\Jump (4).png");
        Bitmap Jump5 = new Bitmap(@"GRAFIKA\SANTA\Jump (5).png");
        Bitmap Jump6 = new Bitmap(@"GRAFIKA\SANTA\Jump (6).png");
        Bitmap Jump7 = new Bitmap(@"GRAFIKA\SANTA\Jump (7).png");
        Bitmap Jump8 = new Bitmap(@"GRAFIKA\SANTA\Jump (8).png");
        Bitmap Jump9 = new Bitmap(@"GRAFIKA\SANTA\Jump (9).png");
        Bitmap Jump10 = new Bitmap(@"GRAFIKA\SANTA\Jump (10).png");
        Bitmap Jump11 = new Bitmap(@"GRAFIKA\SANTA\Jump (11).png");
        Bitmap Jump12 = new Bitmap(@"GRAFIKA\SANTA\Jump (12).png");
        Bitmap Jump13 = new Bitmap(@"GRAFIKA\SANTA\Jump (13).png");
        Bitmap Jump14 = new Bitmap(@"GRAFIKA\SANTA\Jump (14).png");
        Bitmap Jump15 = new Bitmap(@"GRAFIKA\SANTA\Jump (15).png");
        Bitmap Jump16 = new Bitmap(@"GRAFIKA\SANTA\Jump (16).png");

        List<Bitmap> Slide = new List<Bitmap>();
        Bitmap Slide1 = new Bitmap(@"GRAFIKA\SANTA\Slide (1).png");
        Bitmap Slide2 = new Bitmap(@"GRAFIKA\SANTA\Slide (2).png");
        Bitmap Slide3 = new Bitmap(@"GRAFIKA\SANTA\Slide (3).png");
        Bitmap Slide4 = new Bitmap(@"GRAFIKA\SANTA\Slide (4).png");
        Bitmap Slide5 = new Bitmap(@"GRAFIKA\SANTA\Slide (5).png");
        Bitmap Slide6 = new Bitmap(@"GRAFIKA\SANTA\Slide (6).png");
        Bitmap Slide7 = new Bitmap(@"GRAFIKA\SANTA\Slide (7).png");
        Bitmap Slide8 = new Bitmap(@"GRAFIKA\SANTA\Slide (8).png");
        Bitmap Slide9 = new Bitmap(@"GRAFIKA\SANTA\Slide (9).png");
        Bitmap Slide10 = new Bitmap(@"GRAFIKA\SANTA\Slide (10).png");
        Bitmap Slide11 = new Bitmap(@"GRAFIKA\SANTA\Slide (11).png");
        #endregion
        public int direction = 0, fast = 0, jump = 0, slide=0, snow = 0;
        public int posX=30, posY=30, snoX=30, snoY = 30, sn=0;

        public int i = 0, d=0, r=0, w=0, j=0, s=0, s2=0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D:
                    direction = 0;
                    break;
                case Keys.A:
                    direction = 0;
                    break;
                case Keys.S:
                    slide = 0;
                    break;
                case Keys.Q:
                    fast = 0;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D:
                    direction = 1;
                    break;
                case Keys.A:
                    direction = 2;
                    break;
                case Keys.S:
                    if (direction == 0) break;
                    else slide = 1;
                    break;
                case Keys.W:
                    jump = 1;
                    break;
                case Keys.Q:
                    fast = 1;
                    break;
                case Keys.Space:
                    snow = 1;
                    break;
                default:
                    direction = 0;
                    fast = 0;
                    slide = 0;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Timer gameLoop = new Timer();
            gameLoop.Interval = 1000/26;
            gameLoop.Tick += new EventHandler(Gra);

            #region GRAFIKA2
            Idle.Add(Idle1);
            Idle.Add(Idle2);
            Idle.Add(Idle3);
            Idle.Add(Idle4);
            Idle.Add(Idle5);
            Idle.Add(Idle6);
            Idle.Add(Idle7);
            Idle.Add(Idle8);
            Idle.Add(Idle9);
            Idle.Add(Idle10);
            Idle.Add(Idle11);
            Idle.Add(Idle12);
            Idle.Add(Idle13);
            Idle.Add(Idle14);
            Idle.Add(Idle15);
            Idle.Add(Idle16);

            Dead.Add(Dead1);
            Dead.Add(Dead2);
            Dead.Add(Dead3);
            Dead.Add(Dead4);
            Dead.Add(Dead5);
            Dead.Add(Dead6);
            Dead.Add(Dead7);
            Dead.Add(Dead8);
            Dead.Add(Dead9);
            Dead.Add(Dead10);
            Dead.Add(Dead11);
            Dead.Add(Dead12);
            Dead.Add(Dead13);
            Dead.Add(Dead14);
            Dead.Add(Dead15);
            Dead.Add(Dead16);
            Dead.Add(Dead17);

            Run.Add(Run1);
            Run.Add(Run2);
            Run.Add(Run3);
            Run.Add(Run4);
            Run.Add(Run5);
            Run.Add(Run6);
            Run.Add(Run7);
            Run.Add(Run8);
            Run.Add(Run9);
            Run.Add(Run10);
            Run.Add(Run11);

            Walk.Add(Walk1);
            Walk.Add(Walk2);
            Walk.Add(Walk3);
            Walk.Add(Walk4);
            Walk.Add(Walk5);
            Walk.Add(Walk6);
            Walk.Add(Walk7);
            Walk.Add(Walk8);
            Walk.Add(Walk9);
            Walk.Add(Walk10);
            Walk.Add(Walk11);
            Walk.Add(Walk12);
            Walk.Add(Walk13);

            Jump.Add(Jump1);
            Jump.Add(Jump2);
            Jump.Add(Jump3);
            Jump.Add(Jump4);
            Jump.Add(Jump5);
            Jump.Add(Jump6);
            Jump.Add(Jump7);
            Jump.Add(Jump8);
            Jump.Add(Jump9);
            Jump.Add(Jump10);
            Jump.Add(Jump11);
            Jump.Add(Jump12);
            Jump.Add(Jump13);
            Jump.Add(Jump14);
            Jump.Add(Jump15);
            Jump.Add(Jump16);

            Slide.Add(Slide1);
            Slide.Add(Slide2);
            Slide.Add(Slide3);
            Slide.Add(Slide4);
            Slide.Add(Slide5);
            Slide.Add(Slide6);
            Slide.Add(Slide8);
            Slide.Add(Slide9);
            Slide.Add(Slide10);
            Slide.Add(Slide11);
            #endregion


            gameLoop.Start();
        }

        public void bgPB_Paint(object sender, PaintEventArgs e)
        {
            
           Graphics graphics = e.Graphics;
           
           if (snow == 1)
            {
                snow = 0;
                snoX = posX + 80;
                snoY = posY +50;
                sn = 1;
            }
            if (snoX < 800 && sn == 1)
            {
                graphics.DrawImage(new Bitmap(@"GRAFIKA\ball.png"), snoX, snoY, 1024 / 25, 1025 / 25);
                snoX += 12;
            }
            else sn = 0;

            switch (direction){
                case 1:
                    if (fast == 1)
                    {
                        if (jump == 1)
                        {
                            graphics.DrawImage(Jump[j], posX, posY, 934 / 4, 631 / 4);
                            if (j <= 7) posY -= 12;
                            else posY += 12;
                            if (j != Jump.Count() - 1) j++;
                            else
                            {
                                j = 0;
                                jump = 0;
                            }
                        }
                        else if (slide == 1)
                        {
                            graphics.DrawImage(Slide[s], posX, posY, 934 / 4, 631 / 4);
                            if (s != Slide.Count() - 1) s++;
                            else s = 0;
                        }
                        else
                        {
                            graphics.DrawImage(Run[r], posX, posY, 934 / 4, 631 / 4);
                            if (r != Run.Count() - 1) r++;
                            else r = 0;
                        }
                        posX += 12;
                    }
                    else
                    {
                        if (jump == 1)
                        {
                            graphics.DrawImage(Jump[j], posX, posY, 934 / 4, 631 / 4);
                            if (j <= 7) posY -= 12;
                            else posY += 12;
                            if (j != Jump.Count() - 1) j++;
                            else
                            {
                                j = 0;
                                jump = 0;
                            }
                        }
                        else if (slide == 1)
                        {
                            graphics.DrawImage(Slide[s], posX, posY, 934 / 4, 631 / 4);
                            if (s != Slide.Count() - 1) s++;
                            else s = 0;
                        }
                        else
                        {
                            graphics.DrawImage(Walk[w], posX, posY, 934 / 4, 631 / 4);
                            if (w != Walk.Count() - 1) w++;
                            else w = 0;
                        }
                        posX += 6;
                    }
                    break;

                case 2:
    
                    if (fast == 1)
                    {
                        if (jump == 1)
                        {
                            graphics.DrawImage(Jump[j], posX, posY, 934 / 4, 631 / 4);
                            if (j <= 7) posY -= 12;
                            else posY += 12;
                            if (j != Jump.Count() - 1) j++;
                            else
                            {
                                j = 0;
                                jump = 0;
                            }
                        }
                        else if (slide == 1)
                        {
                            graphics.DrawImage(Slide[s], posX, posY, 934 / 4, 631 / 4);
                            if (s != Slide.Count() - 1) s++;
                            else s = 0;
                        }
                        else
                        {
                            graphics.DrawImage(Run[r], posX, posY, 934 / 4, 631 / 4);
                            if (r != Run.Count() - 1) r++;
                            else r = 0;
                        }
                        posX -= 12;
                    }
                    else
                    {
                        if (jump == 1)
                        {
                            graphics.DrawImage(Jump[j], posX, posY, 934 / 4, 631 / 4);
                            if (j <= 7) posY -= 12;
                            else posY += 12;
                            if (j != Jump.Count() - 1) j++;
                            else
                            {
                                j = 0;
                                jump = 0;
                            }
                        }
                        else if (slide == 1)
                        {
                            graphics.DrawImage(Slide[s], posX, posY, 934 / 4, 631 / 4);
                            if (s != Slide.Count() - 1) s++;
                            else s = 0;
                        }
                        else
                        {
                            graphics.DrawImage(Walk[w], posX, posY, 934 / 4, 631 / 4);
                            if (w != Walk.Count() - 1) w++;
                            else w = 0;
                        }
                        posX -= 6;
                    }
                    break;

                default:
                    if (jump == 1)
                    {
                        graphics.DrawImage(Jump[j], posX, posY, 934 / 4, 631 / 4);
                        if (j <= 7) posY -= 12;
                        else posY += 12;
                        if (j != Jump.Count() - 1) j++;
                        else
                        {
                            j = 0;
                            jump = 0;
                        }
                    }
                    else
                    {
                        graphics.DrawImage(Idle[i], posX, posY, 934 / 4, 631 / 4);
                        if (i != Idle.Count() - 1) i++;
                        else i = 0;
                    }
                    break;

            }
        }

        private void Gra(object sender, EventArgs e)
        {
            bgPB.Invalidate();
        }

    }
}

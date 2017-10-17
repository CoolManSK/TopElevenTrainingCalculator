using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopElevenTrainingCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        struct Result
        {
            public String Name;
            public int Counter;
            public int TotalSkills;
            public String Position;
        }

        public class Skills
        {
            public const int AerialReach = 1;
            public const int Aggression = 2;
            public const int Agility = 3;
            public const int Anticipation = 4;
            public const int Bravery = 5;
            public const int Communication = 6;
            public const int Concentration = 7;
            public const int Creativity = 8;
            public const int Crossing = 9;
            public const int Dribbling = 10;
            public const int Finishing = 11;
            public const int Fitness = 12;
            public const int Heading = 13;
            public const int Kicking = 14;
            public const int Marking = 15;
            public const int Passing = 16;
            public const int Positioning = 17;
            public const int Punching = 18;
            public const int Reflexes = 19;
            public const int RushingOut = 20;
            public const int Shooting = 21;
            public const int Speed = 22;
            public const int Strength = 23;
            public const int Tackling = 24;
            public const int Throwing = 25;            
        }

        public class Drills
        {
            public class DrillPrototype
            {
                public String TextName = "";
                public String Position = "";
                public String Intensity = "";
                public Double IntPercent = 0.0f;                
                public int ExpPoints = 0;
                public int[] Attributes = { };

                public int NumberOfSelectedSkills = 0;

                public DrillPrototype(String TextName, String Position, String Intensity, Double IntPercent, int ExpPoints)
                {
                    this.TextName = TextName;
                    this.Position = Position;
                    this.Intensity = Intensity;
                    this.IntPercent = IntPercent;
                    this.ExpPoints = ExpPoints;
                }
            }

            public DrillPrototype[] DrillsList;

            private DrillPrototype PassGoAndShoot;
            private DrillPrototype FastCounterAttacks;
            private DrillPrototype SkillDrill;
            private DrillPrototype ShootingTechnique;
            private DrillPrototype SetPieceDelivery;
            private DrillPrototype SlalomDribble;
            private DrillPrototype WingPlay;
            private DrillPrototype OneOnOneFinishing;
            private DrillPrototype PressThePlay;
            private DrillPrototype PiggyInTheMiddle;
            private DrillPrototype GoalkeeperTraining;
            private DrillPrototype UseYourHead;
            private DrillPrototype StopTheAttacker;
            private DrillPrototype DefendingCrosses;
            private DrillPrototype VideoAnalysis;
            private DrillPrototype OneLineOfDefense;
            private DrillPrototype WarmUp;
            private DrillPrototype Stretch;
            private DrillPrototype Sprint;
            private DrillPrototype CariocaWithLadders;
            private DrillPrototype LongRun;
            private DrillPrototype Gym;
            private DrillPrototype ShuttleRuns;
            private DrillPrototype HurdleJumps;


            public Drills()
            {
                this.DrillsList = new DrillPrototype[24];

                this.PassGoAndShoot = new DrillPrototype("PASS, GO AND SHOOT", "ATTACK", "Easy", 1.5f, 2);
                this.PassGoAndShoot.Attributes = new int[] { Skills.Speed, Skills.Passing, Skills.Shooting, Skills.Anticipation };
                this.DrillsList.SetValue(this.PassGoAndShoot, 0);

                this.FastCounterAttacks = new DrillPrototype("FAST COUNTER-ATTACKS", "ATTACK", "Very hard", 3.75f, 5);
                this.FastCounterAttacks.Attributes = new int[] { Skills.Creativity, Skills.Passing, Skills.Crossing, Skills.Finishing, Skills.Communication };
                this.DrillsList.SetValue(this.FastCounterAttacks, 1);

                this.SkillDrill = new DrillPrototype("SKILL DRILL", "ATTACK", "Very easy", 0.75f, 1);
                this.SkillDrill.Attributes = new int[] { Skills.Creativity, Skills.Dribbling, Skills.Heading, Skills.Concentration };
                this.DrillsList.SetValue(this.SkillDrill, 2);

                this.ShootingTechnique = new DrillPrototype("SHOOTING TECHNIQUE", "ATTACK", "Medium", 2.25f, 3);
                this.ShootingTechnique.Attributes = new int[] { Skills.Strength, Skills.Shooting, Skills.Finishing, Skills.Reflexes, Skills.Agility };
                this.DrillsList.SetValue(this.ShootingTechnique, 3);

                this.SetPieceDelivery = new DrillPrototype("SET-PIECE DELIVERY", "ATTACK", "Medium", 2.25f, 3);
                this.SetPieceDelivery.Attributes = new int[] { Skills.Crossing, Skills.Shooting, Skills.Marking, Skills.Heading, Skills.RushingOut };
                this.DrillsList.SetValue(this.SetPieceDelivery, 4);

                this.SlalomDribble = new DrillPrototype("SLALOM DRIBBLE", "ATTACK", "Hard", 3.0f, 4);
                this.SlalomDribble.Attributes = new int[] { Skills.Fitness, Skills.Speed, Skills.Passing, Skills.Dribbling };
                this.DrillsList.SetValue(this.SlalomDribble, 5);

                this.WingPlay = new DrillPrototype("WING PLAY", "ATTACK", "Hard", 3.0f, 4);
                this.WingPlay.Attributes = new int[] { Skills.Crossing, Skills.Shooting, Skills.Finishing, Skills.Heading, Skills.Punching };
                this.DrillsList.SetValue(this.WingPlay, 6);

                this.OneOnOneFinishing = new DrillPrototype("1-ON-1 FINISHING", "ATTACK", "Easy", 1.5f, 2);
                this.OneOnOneFinishing.Attributes = new int[] { Skills.Dribbling, Skills.Finishing, Skills.Tackling, Skills.Anticipation, Skills.RushingOut};
                this.DrillsList.SetValue(this.OneOnOneFinishing, 7);

                this.PressThePlay = new DrillPrototype("PRESS THE PLAY", "DEFENSE", "Hard", 3.0f, 4);
                this.PressThePlay.Attributes = new int[] { Skills.Aggression, Skills.Tackling, Skills.Marking, Skills.Positioning, Skills.Bravery };
                this.DrillsList.SetValue(this.PressThePlay, 8);

                this.PiggyInTheMiddle = new DrillPrototype("PIGGY IN THE MIDDLE", "DEFENSE", "Easy", 1.5f, 2);
                this.PiggyInTheMiddle.Attributes = new int[] { Skills.Fitness, Skills.Aggression, Skills.Passing, Skills.Tackling, Skills.Positioning };
                this.DrillsList.SetValue(this.PiggyInTheMiddle, 9);

                this.GoalkeeperTraining = new DrillPrototype("GOALKEEPER TRAINING", "DEFENSE", "Hard", 3.0f, 4);
                this.GoalkeeperTraining.Attributes = new int[] { Skills.Reflexes, Skills.Agility, Skills.Throwing, Skills.Kicking, Skills.AerialReach };
                this.DrillsList.SetValue(this.GoalkeeperTraining, 10);

                this.UseYourHead = new DrillPrototype("USE YOUR HEAD", "DEFENSE", "Easy", 1.5f, 2);
                this.UseYourHead.Attributes = new int[] { Skills.Creativity, Skills.Passing, Skills.Positioning, Skills.Heading };
                this.DrillsList.SetValue(this.UseYourHead, 11);
                
                this.StopTheAttacker = new DrillPrototype("STOP THE ATTACKER", "DEFENSE", "Medium", 2.25f, 3);
                this.StopTheAttacker.Attributes = new int[] { Skills.Strength, Skills.Dribbling, Skills.Tackling, Skills.Marking, Skills.Bravery };
                this.DrillsList.SetValue(this.StopTheAttacker, 12);

                this.DefendingCrosses = new DrillPrototype("DEFENDING CROSSES", "DEFENSE", "Medium", 2.25f, 3);
                this.DefendingCrosses.Attributes = new int[] { Skills.Crossing, Skills.Marking, Skills.Heading, Skills.Bravery, Skills.AerialReach };
                this.DrillsList.SetValue(this.DefendingCrosses, 13);

                this.VideoAnalysis = new DrillPrototype("VIDEO ANALYSIS", "DEFENSE", "Very easy", 0.75f, 1);
                this.VideoAnalysis.Attributes = new int[] { Skills.Creativity, Skills.Positioning, Skills.Bravery, Skills.Communication };
                this.DrillsList.SetValue(this.VideoAnalysis, 14);

                this.OneLineOfDefense = new DrillPrototype("ONE LINE OF DEFENSE", "DEFENSE", "Medium", 2.25f, 3);
                this.OneLineOfDefense.Attributes = new int[] { Skills.Marking, Skills.Positioning, Skills.Communication, Skills.Concentration };
                this.DrillsList.SetValue(this.OneLineOfDefense, 15);

                this.WarmUp = new DrillPrototype("WARM-UP", "PHYSandMENTAL", "Very easy", 0.75f, 1);
                this.WarmUp.Attributes = new int[] { Skills.Fitness, Skills.Aggression, Skills.Heading, Skills.Reflexes };
                this.DrillsList.SetValue(this.WarmUp, 16);

                this.Stretch = new DrillPrototype("STRETCH", "PHYSandMENTAL", "Easy", 1.5f, 2);
                this.Stretch.Attributes = new int[] { Skills.Fitness, Skills.Strength, Skills.Speed, Skills.Agility };
                this.DrillsList.SetValue(this.Stretch, 17);

                this.Sprint = new DrillPrototype("SPRINT", "PHYSandMENTAL", "Very hard", 3.75f, 5);
                this.Sprint.Attributes = new int[] { Skills.Fitness, Skills.Speed, Skills.Dribbling, Skills.RushingOut };
                this.DrillsList.SetValue(this.Sprint, 18);

                this.CariocaWithLadders = new DrillPrototype("CARIOCA WITH LADDERS", "PHYSandMENTAL", "Easy", 1.5f, 2);
                this.CariocaWithLadders.Attributes = new int[] { Skills.Aggression, Skills.Speed, Skills.Agility, Skills.Concentration };
                this.DrillsList.SetValue(this.CariocaWithLadders, 19);

                this.LongRun = new DrillPrototype("LONG RUN", "PHYSandMENTAL", "Medium", 2.25f, 3);
                this.LongRun.Attributes = new int[] { Skills.Fitness, Skills.Speed, Skills.Concentration };
                this.DrillsList.SetValue(this.LongRun, 20);

                this.Gym = new DrillPrototype("GYM", "PHYSandMENTAL", "Very hard", 3.75f, 5);
                this.Gym.Attributes = new int[] { Skills.Fitness, Skills.Strength, Skills.Throwing, Skills.Kicking };
                this.DrillsList.SetValue(this.Gym, 21);

                this.ShuttleRuns = new DrillPrototype("SHUTTLE RUNS", "PHYSandMENTAL", "Hard", 3.0f, 4);
                this.ShuttleRuns.Attributes = new int[] { Skills.Strength, Skills.Speed, Skills.Bravery, Skills.Agility };
                this.DrillsList.SetValue(this.ShuttleRuns, 22);

                this.HurdleJumps = new DrillPrototype("HURDLE JUMPS", "PHYSandMENTAL", "Hard", 3.0f, 4);
                this.HurdleJumps.Attributes = new int[] { Skills.Aggression, Skills.Speed, Skills.Bravery, Skills.Kicking };
                this.DrillsList.SetValue(this.HurdleJumps, 23);

            }     
        }

        public class PlayerSkillComboBox : ComboBox
        {
            public int Index = 0;
            public PlayerSkillComboBox()
            {
                this.Items.Add("AerialReach");
                this.Items.Add("Aggression");
                this.Items.Add("Agility");
                this.Items.Add("Anticipation");
                this.Items.Add("Bravery");
                this.Items.Add("Communication");
                this.Items.Add("Concentration");
                this.Items.Add("Creativity");
                this.Items.Add("Crossing");
                this.Items.Add("Dribbling");
                this.Items.Add("Finishing");
                this.Items.Add("Fitness");
                this.Items.Add("Heading");
                this.Items.Add("Kicking");
                this.Items.Add("Marking");
                this.Items.Add("Passing");
                this.Items.Add("Positioning");
                this.Items.Add("Punching");
                this.Items.Add("Reflexes");
                this.Items.Add("RushingOut");
                this.Items.Add("Shooting");
                this.Items.Add("Speed");
                this.Items.Add("Strength");
                this.Items.Add("Tackling");
                this.Items.Add("Throwing");
            }

            public PlayerSkillComboBox(int Index) : this()
            {
                this.Index = Index;                          
            }

            protected override void OnSelectedValueChanged(EventArgs e)
            {
                if (this.Index == (this.Parent.Controls.Count - 1))
                {
                    PlayerSkillComboBox psc_Next = new PlayerSkillComboBox(this.Index + 1);
                    psc_Next.DropDownStyle = ComboBoxStyle.DropDownList;
                    psc_Next.Size = new Size(100, 20);
                    psc_Next.Left = 10;
                    psc_Next.Top = this.Top + 25;
                    this.Parent.Controls.Add(psc_Next);
                }
                base.OnSelectedValueChanged(e);                    
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PlayerSkillComboBox psc_First = new PlayerSkillComboBox();
            psc_First.DropDownStyle = ComboBoxStyle.DropDownList;
            psc_First.Size = new Size(100, 20);
            psc_First.Left = 10;
            psc_First.Top = 20;
            this.gb_PlayerSkills.Controls.Add(psc_First);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ar_ChosenSkills = { };
            
            foreach (Control actControl in this.gb_PlayerSkills.Controls)
            {
                PlayerSkillComboBox actPSC = (PlayerSkillComboBox)actControl;
                if (actPSC.SelectedIndex != -1)
                {
                    Array.Resize(ref ar_ChosenSkills, ar_ChosenSkills.Length + 1);
                    ar_ChosenSkills.SetValue(actPSC.SelectedIndex + 1, ar_ChosenSkills.Length - 1);
                }
            }

            Drills allDrills = new Drills();



            foreach (Drills.DrillPrototype actDrill in allDrills.DrillsList)
            {
                foreach (int actChosenSkill in ar_ChosenSkills)
                {
                    for (int i = 0; i < actDrill.Attributes.Length; i++)
                    {
                        if (actDrill.Attributes[i] == actChosenSkill)
                        {
                            actDrill.NumberOfSelectedSkills++;
                        }
                    }
                }
            }

            Result[] results = { };

            int counter = 6;
            while (counter > 0)
            {
                foreach (Drills.DrillPrototype actDrill in allDrills.DrillsList)
                {
                    if (actDrill.NumberOfSelectedSkills == counter)
                    {
                        Result actResult = new Result();
                        actResult.Name = actDrill.TextName;
                        actResult.Counter = counter;
                        actResult.TotalSkills = actDrill.Attributes.Length;
                        actResult.Position = actDrill.Position;
                        Array.Resize(ref results, results.Length + 1);
                        results.SetValue(actResult, results.Length - 1);
                    }
                }
                counter--;
            }

            this.dgv_Results.Rows.Clear();

            DataGridViewRow actRow = new DataGridViewRow();
            foreach (Result actRes in results)
            {
                this.dgv_Results.Rows.Add(actRes.Name, actRes.Counter.ToString(), actRes.TotalSkills.ToString(), actRes.Position);
            }
        }
    }
}

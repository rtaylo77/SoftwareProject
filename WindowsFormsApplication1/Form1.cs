using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Image[] stack1 = new Image[4];
        public Image[] stack2 = new Image[4];
        public Image[] stack3 = new Image[4];
        public Image[] stack4 = new Image[4];
        public Image[] stack5 = new Image[4];
        public Image[] stack6 = new Image[4];
        public Image[] stack7 = new Image[4];
        public Image[] stack8 = new Image[4];
        public Image[] stack9 = new Image[4];
        public Image[] stack10 = new Image[4];
        public Image[] stack11 = new Image[4];
        public Image[] stack12 = new Image[4];
        public Image[] stack13 = new Image[4];
        public Image[] cards = new Image[52];
        public int[] array = new int[52];
        public int arrayCount = 0;
        public int countStack1 = 3;
        public int countStack2 = 3;
        public int countStack3 = 3;
        public int countStack4 = 3;
        public int countStack5 = 3;
        public int countStack6 = 3;
        public int countStack7 = 3;
        public int countStack8 = 3;
        public int countStack9 = 3;
        public int countStack10 = 3;
        public int countStack11 = 3;
        public int countStack12 = 3;
        public int countStack13 = 3;
        public string[] f1Stack = new string[13];
        public string[] f2Stack = new string[13];
        public string[] f3Stack = new string[13];
        public string[] f4Stack = new string[13];
        int f1Count = 0;
        int f2Count = 0;
        int f3Count = 0;
        int f4Count = 0;
        public Form1()
        {
            InitializeComponent();
            populateCards();
            populateFstacks();
            //Put the kings in the stacks
            stack1[0] = cards[44];
            stack6[0] = cards[45];
            stack9[0] = cards[46];
            stack12[0] = cards[47];
            stack3[0] = cards[0];
            array[0] = 44;
            array[1] = 45;
            array[2] = 46;
            array[3] = 47;
            arrayCount = 5;
            stack1 = populateStacks(stack1);
            stack2 = populateStacks(stack2);
            stack3 = populateStacks(stack3);
            stack4 = populateStacks(stack4);
            stack5 = populateStacks(stack5);
            stack6 = populateStacks(stack6);
            stack7 = populateStacks(stack7);
            stack8 = populateStacks(stack8);
            stack9 = populateStacks(stack9);
            stack10 = populateStacks(stack10);
            stack11 = populateStacks(stack11);
            stack12 = populateStacks(stack12);
            stack13 = populateStacks(stack13);


            panel1.Controls.Add(t2);
            panel1.Controls.Add(t3);
            panel1.Controls.Add(t1);
            panel1.Controls.Add(t4);
            panel1.Controls.Add(t5);
            panel1.Controls.Add(t6);
            panel1.Controls.Add(t7);
            panel1.Controls.Add(t8);
            panel1.Controls.Add(t9);
            panel1.Controls.Add(t10);
            panel1.Controls.Add(t11);
            panel1.Controls.Add(t12);
            panel1.Controls.Add(t13);
            foundations.Controls.Add(f1);
            foundations.Controls.Add(f2);
            foundations.Controls.Add(f3);
            foundations.Controls.Add(f4);
            populatePictures();
        }

        public void populateFstacks()
        {
            f1Stack[0] = "clubsA";
            f1Stack[1] = "clubs2";
            f1Stack[2] = "clubs3";
            f1Stack[3] = "clubs4";
            f1Stack[4] = "clubs5";
            f1Stack[5] = "clubs6";
            f1Stack[6] = "clubs7";
            f1Stack[7] = "clubs8";
            f1Stack[8] = "clubs9";
            f1Stack[9] = "clubs10";
            f1Stack[10] = "clubsJ";
            f1Stack[11] = "clubsQ";
            f1Stack[12] = "clubsK";

            f2Stack[0] = "diamondsA";
            f2Stack[1] = "diamonds2";
            f2Stack[2] = "diamonds3";
            f2Stack[3] = "diamonds4";
            f2Stack[4] = "diamonds5";
            f2Stack[5] = "diamonds6";
            f2Stack[6] = "diamonds7";
            f2Stack[7] = "diamonds8";
            f2Stack[8] = "diamonds9";
            f2Stack[9] = "diamonds10";
            f2Stack[10] = "diamondsJ";
            f2Stack[11] = "diamondsQ";
            f2Stack[12] = "diamondsK";

            f3Stack[0] = "heartsA";
            f3Stack[1] = "hearts2";
            f3Stack[2] = "hearts3";
            f3Stack[3] = "hearts4";
            f3Stack[4] = "hearts5";
            f3Stack[5] = "hearts6";
            f3Stack[6] = "hearts7";
            f3Stack[7] = "hearts8";
            f3Stack[8] = "hearts9";
            f3Stack[9] = "hearts10";
            f3Stack[10] = "heartsJ";
            f3Stack[11] = "heartsQ";
            f3Stack[12] = "heartsK";

            f4Stack[0] = "spadesA";
            f4Stack[1] = "spades2";
            f4Stack[2] = "spades3";
            f4Stack[3] = "spades4";
            f4Stack[4] = "spades5";
            f4Stack[5] = "spades6";
            f4Stack[6] = "spades7";
            f4Stack[7] = "spades8";
            f4Stack[8] = "spades9";
            f4Stack[9] = "spades10";
            f4Stack[10] = "spadesJ";
            f4Stack[11] = "spadesQ";
            f4Stack[12] = "spadesK";


        }
        public void populatePictures()
        {
            //Picture box size for card is 126,189
            t1.Image = stack1[3];
            t2.Image = stack2[3];
            t3.Image = stack3[3];
            t4.Image = stack4[3];
            t5.Image = stack5[3];
            t6.Image = stack6[3];
            t7.Image = stack7[3];
            t8.Image = stack8[3];
            t9.Image = stack9[3];
            t10.Image = stack10[3];
            t11.Image = stack11[3];
            t12.Image = stack12[3];
            t13.Image = stack13[3];
        }
        public bool checkRandom(int a)
        {
            if (array.Contains<int>(a))
                return false;
            else if (!array.Contains<int>(a))
                return true;
            else
                return false;
        }
        public void addToArray(int a)
        {
            array[arrayCount] = a;
            arrayCount++;
        }
        public Image[] populateStacks(Image[] stack)
        {
            int Seed = (int)DateTime.Now.Ticks;
            Random rand = new Random(Seed);
            int random = 0;
            int count1 = 1;
            int count2 = 0;
            //Check if king stack
            if (stack[0] != null)
            {
                while(count1 < 4)
                {
                    random = rand.Next(1,52);
                    if (checkRandom(random))
                    {
                        stack[count1] = cards[random];
                        addToArray(random);
                        count1++;
                    }
                }
            }
            else if(stack[0] == null)
            {
                while(count2 < 4)
                {
                    random = rand.Next(1, 52);
                    if (checkRandom(random))
                    {
                        stack[count2] = cards[random];
                        addToArray(random);
                        count2++;
                    }
                }
            }
            return stack;
        }
        public void populateCards()
        {
            Image clubs10 = new Bitmap(WindowsFormsApplication1.Properties.Resources._10_of_clubs);
            Image diamonds10 = new Bitmap(WindowsFormsApplication1.Properties.Resources._10_of_diamonds);
            Image hearts10 = new Bitmap(WindowsFormsApplication1.Properties.Resources._10_of_hearts);
            Image spades10 = new Bitmap(WindowsFormsApplication1.Properties.Resources._10_of_spades);
            Image clubs2 = new Bitmap(WindowsFormsApplication1.Properties.Resources._2_of_clubs);
            Image diamonds2 = new Bitmap(WindowsFormsApplication1.Properties.Resources._2_of_diamonds);
            Image hearts2 = new Bitmap(WindowsFormsApplication1.Properties.Resources._2_of_hearts);
            Image spades2 = new Bitmap(WindowsFormsApplication1.Properties.Resources._2_of_spades);
            Image clubs3 = new Bitmap(WindowsFormsApplication1.Properties.Resources._3_of_clubs);
            Image diamonds3 = new Bitmap(WindowsFormsApplication1.Properties.Resources._3_of_diamonds);
            Image hearts3 = new Bitmap(WindowsFormsApplication1.Properties.Resources._3_of_hearts);
            Image spades3 = new Bitmap(WindowsFormsApplication1.Properties.Resources._3_of_spades);
            Image clubs4 = new Bitmap(WindowsFormsApplication1.Properties.Resources._4_of_clubs);
            Image diamonds4 = new Bitmap(WindowsFormsApplication1.Properties.Resources._4_of_diamonds);
            Image hearts4 = new Bitmap(WindowsFormsApplication1.Properties.Resources._4_of_hearts);
            Image spades4 = new Bitmap(WindowsFormsApplication1.Properties.Resources._4_of_spades);
            Image clubs5 = new Bitmap(WindowsFormsApplication1.Properties.Resources._5_of_clubs);
            Image diamonds5 = new Bitmap(WindowsFormsApplication1.Properties.Resources._5_of_diamonds);
            Image hearts5 = new Bitmap(WindowsFormsApplication1.Properties.Resources._5_of_hearts);
            Image spades5 = new Bitmap(WindowsFormsApplication1.Properties.Resources._5_of_spades);
            Image clubs6 = new Bitmap(WindowsFormsApplication1.Properties.Resources._6_of_clubs);
            Image diamonds6 = new Bitmap(WindowsFormsApplication1.Properties.Resources._6_of_diamonds);
            Image hearts6 = new Bitmap(WindowsFormsApplication1.Properties.Resources._6_of_hearts);
            Image spades6 = new Bitmap(WindowsFormsApplication1.Properties.Resources._6_of_spades);
            Image clubs7 = new Bitmap(WindowsFormsApplication1.Properties.Resources._7_of_clubs);
            Image diamonds7 = new Bitmap(WindowsFormsApplication1.Properties.Resources._7_of_diamonds);
            Image hearts7 = new Bitmap(WindowsFormsApplication1.Properties.Resources._7_of_hearts);
            Image spades7 = new Bitmap(WindowsFormsApplication1.Properties.Resources._7_of_spades);
            Image clubs8 = new Bitmap(WindowsFormsApplication1.Properties.Resources._8_of_clubs);
            Image diamonds8 = new Bitmap(WindowsFormsApplication1.Properties.Resources._8_of_diamonds);
            Image hearts8 = new Bitmap(WindowsFormsApplication1.Properties.Resources._8_of_hearts);
            Image spades8 = new Bitmap(WindowsFormsApplication1.Properties.Resources._8_of_spades);
            Image clubs9 = new Bitmap(WindowsFormsApplication1.Properties.Resources._9_of_clubs);
            Image diamonds9 = new Bitmap(WindowsFormsApplication1.Properties.Resources._9_of_diamonds);
            Image hearts9 = new Bitmap(WindowsFormsApplication1.Properties.Resources._9_of_hearts);
            Image spades9 = new Bitmap(WindowsFormsApplication1.Properties.Resources._9_of_spades);
            Image clubsJ = new Bitmap(WindowsFormsApplication1.Properties.Resources.jack_of_clubs2);
            Image diamondsJ = new Bitmap(WindowsFormsApplication1.Properties.Resources.jack_of_diamonds2);
            Image heartsJ = new Bitmap(WindowsFormsApplication1.Properties.Resources.jack_of_hearts2);
            Image spadesJ = new Bitmap(WindowsFormsApplication1.Properties.Resources.jack_of_spades2);
            Image clubsK = new Bitmap(WindowsFormsApplication1.Properties.Resources.king_of_clubs2);
            Image diamondsK = new Bitmap(WindowsFormsApplication1.Properties.Resources.king_of_diamonds2);
            Image heartsK = new Bitmap(WindowsFormsApplication1.Properties.Resources.king_of_hearts2);
            Image spadesK = new Bitmap(WindowsFormsApplication1.Properties.Resources.king_of_spades2);
            Image clubsQ = new Bitmap(WindowsFormsApplication1.Properties.Resources.queen_of_clubs2);
            Image diamondsQ = new Bitmap(WindowsFormsApplication1.Properties.Resources.queen_of_diamonds2);
            Image heartsQ = new Bitmap(WindowsFormsApplication1.Properties.Resources.queen_of_hearts2);
            Image spadesQ = new Bitmap(WindowsFormsApplication1.Properties.Resources.queen_of_spades2);
            Image clubsA = new Bitmap(WindowsFormsApplication1.Properties.Resources.ace_of_clubs);
            Image diamondsA = new Bitmap(WindowsFormsApplication1.Properties.Resources.ace_of_diamonds);
            Image heartsA = new Bitmap(WindowsFormsApplication1.Properties.Resources.ace_of_hearts);
            Image spadesA = new Bitmap(WindowsFormsApplication1.Properties.Resources.ace_of_spades);

            cards[0] = clubs10;
            cards[0].Tag = "clubs10";
            cards[1] = diamonds10;
            cards[1].Tag = "diamonds10";
            cards[2] = hearts10;
            cards[2].Tag = "hearts10";
            cards[3] = spades10;
            cards[3].Tag = "spades10";
            cards[4] = clubs2;
            cards[4].Tag = "clubs2";
            cards[5] = diamonds2;
            cards[5].Tag = "diamonds2";
            cards[6] = hearts2;
            cards[6].Tag = "hearts2";
            cards[7] = spades2;
            cards[7].Tag = "spades2";
            cards[8] = clubs3;
            cards[8].Tag = "clubs3";
            cards[9] = diamonds3;
            cards[9].Tag = "diamonds3";
            cards[10] = hearts3;
            cards[10].Tag = "hearts3";
            cards[11] = spades3;
            cards[11].Tag = "spades3";
            cards[12] = clubs4;
            cards[12].Tag = "clubs4";
            cards[13] = diamonds4;
            cards[13].Tag = "diamonds4";
            cards[14] = hearts4;
            cards[14].Tag = "hearts4";
            cards[15] = spades4;
            cards[15].Tag = "spades4";
            cards[16] = clubs5;
            cards[16].Tag = "clubs5";
            cards[17] = diamonds5;
            cards[17].Tag = "diamonds5";
            cards[18] = hearts5;
            cards[18].Tag = "hearts5";
            cards[19] = spades5;
            cards[19].Tag = "spades5";
            cards[20] = clubs6;
            cards[20].Tag = "clubs6";
            cards[21] = diamonds6;
            cards[21].Tag = "diamonds6";
            cards[22] = hearts6;
            cards[22].Tag = "hearts6";
            cards[23] = spades6;
            cards[23].Tag = "spades6";
            cards[24] = clubs7;
            cards[24].Tag = "clubs7";
            cards[25] = diamonds7;
            cards[25].Tag = "diamonds7";
            cards[26] = hearts7;
            cards[26].Tag = "hearts7";
            cards[27] = spades7;
            cards[27].Tag = "spades7";
            cards[28] = clubs8;
            cards[28].Tag = "clubs8";
            cards[29] = diamonds8;
            cards[29].Tag = "diamonds8";
            cards[30] = hearts8;
            cards[30].Tag = "hearts8";
            cards[31] = spades8;
            cards[31].Tag = "spades8";
            cards[32] = clubs9;
            cards[32].Tag = "clubs9";
            cards[33] = diamonds9;
            cards[33].Tag = "diamonds9";
            cards[34] = hearts9;
            cards[34].Tag = "hearts9";
            cards[35] = spades9;
            cards[35].Tag = "spades9";
            cards[36] = clubsA;
            cards[36].Tag = "clubsA";
            cards[37] = diamondsA;
            cards[37].Tag = "diamondsA";
            cards[38] = heartsA;
            cards[38].Tag = "heartsA";
            cards[39] = spadesA;
            cards[39].Tag = "spadesA";
            cards[40] = clubsJ;
            cards[40].Tag = "clubsJ";
            cards[41] = diamondsJ;
            cards[41].Tag = "diamondsJ";
            cards[42] = heartsJ;
            cards[42].Tag = "heartsJ";
            cards[43] = spadesJ;
            cards[43].Tag = "spadesJ";
            cards[44] = clubsK;
            cards[44].Tag = "clubsK";
            cards[45] = diamondsK;
            cards[45].Tag = "diamondsK";
            cards[46] = heartsK;
            cards[46].Tag = "heartsK";
            cards[47] = spadesK;
            cards[47].Tag = "spadesK";
            cards[48] = clubsQ;
            cards[48].Tag = "clubsQ";
            cards[49] = diamondsQ;
            cards[49].Tag = "diamondsQ";
            cards[50] = heartsQ;
            cards[50].Tag = "heartsQ";
            cards[51] = spadesQ;
            cards[51].Tag = "spadesQ";





        }

        private void t1_Click(object sender, EventArgs e)
        {
            if (countStack1 >= 0)
            {
                if (stack1[countStack1].Tag.ToString().Contains("clubs") && stack1[countStack1].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack1[countStack1];
                    countStack1--;
                    if (countStack1 >= 0)
                        t1.Image = stack1[countStack1];
                    else
                        t1.Image = null;
                    f1Count++;
                }
                else if (stack1[countStack1].Tag.ToString().Contains("diamonds") && stack1[countStack1].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack1[countStack1];
                    countStack1--;
                    if (countStack1 >= 0)
                        t1.Image = stack1[countStack1];
                    else
                        t1.Image = null;
                    f2Count++;
                }
                else if (stack1[countStack1].Tag.ToString().Contains("hearts") && stack1[countStack1].Tag.ToString() == f3Stack[f1Count])
                {
                    f3.Image = stack1[countStack1];
                    countStack1--;
                    if (countStack1 >= 0)
                        t1.Image = stack1[countStack1];
                    else
                        t1.Image = null;
                    f3Count++;
                }
                else if (stack1[countStack1].Tag.ToString().Contains("spades") && stack1[countStack1].Tag.ToString() == f4Stack[f1Count])
                {
                    f4.Image = stack1[countStack1];
                    countStack1--;
                    if (countStack1 >= 0)
                        t1.Image = stack1[countStack1];
                    else
                        t1.Image = null;
                    f4Count++;
                }
            }
        }
        private void t2_Click(object sender, EventArgs e)
        {
            if (countStack2 >= 0)
            {
                if (stack2[countStack2].Tag.ToString().Contains("clubs") && stack2[countStack2].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack2[countStack2];
                    countStack2--;
                    if (countStack2 >= 0)
                        t2.Image = stack2[countStack2];
                    else
                        t2.Image = null;
                    f1Count++;
                }
                else if (stack2[countStack2].Tag.ToString().Contains("diamonds") && stack2[countStack2].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack2[countStack2];
                    countStack2--;
                    if (countStack2 >= 0)
                        t2.Image = stack2[countStack2];
                    else
                        t2.Image = null;
                    f2Count++;
                }
                else if (stack2[countStack2].Tag.ToString().Contains("hearts") && stack2[countStack2].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack2[countStack2];
                    countStack2--;
                    if (countStack2 >= 0)
                        t2.Image = stack2[countStack2];
                    else
                        t2.Image = null;
                    f3Count++;
                }
                else if (stack2[countStack2].Tag.ToString().Contains("spades") && stack2[countStack2].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack2[countStack2];
                    countStack2--;
                    if (countStack2 >= 0)
                        t2.Image = stack2[countStack2];
                    else
                        t2.Image = null;
                    f4Count++;
                }
            }
        }
        private void t3_Click(object sender, EventArgs e)
        {
            if (countStack3 >= 0)
            {
                if (stack3[countStack3].Tag.ToString().Contains("clubs") && stack3[countStack3].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack3[countStack3];
                    countStack3--;
                    if (countStack3 >= 0)
                        t3.Image = stack3[countStack3];
                    else
                        t3.Image = null;
                    f1Count++;
                }
                else if (stack3[countStack3].Tag.ToString().Contains("diamonds") && stack3[countStack3].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack3[countStack3];
                    countStack3--;
                    if (countStack3 >= 0)
                        t3.Image = stack3[countStack3];
                    else
                        t3.Image = null;
                    f2Count++;
                }
                else if (stack3[countStack3].Tag.ToString().Contains("hearts") && stack3[countStack3].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack3[countStack3];
                    countStack3--;
                    if (countStack3 >= 0)
                        t3.Image = stack3[countStack3];
                    else
                        t3.Image = null;
                    f3Count++;
                }
                else if (stack3[countStack3].Tag.ToString().Contains("spades") && stack3[countStack3].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack3[countStack3];
                    countStack3--;
                    if (countStack3 >= 0)
                        t3.Image = stack3[countStack3];
                    else
                        t3.Image = null;
                    f4Count++;
                }
            }
        }
        private void t4_Click(object sender, EventArgs e)
        {
            if (countStack4 >= 0)
            {
                if (stack4[countStack4].Tag.ToString().Contains("clubs") && stack4[countStack4].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack4[countStack4];
                    countStack4--;
                    if (countStack4 >= 0)
                        t4.Image = stack4[countStack4];
                    else
                        t4.Image = null;
                    f1Count++;
                }
                else if (stack4[countStack4].Tag.ToString().Contains("diamonds") && stack4[countStack4].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack4[countStack4];
                    countStack4--;
                    if (countStack4 >= 0)
                        t4.Image = stack4[countStack4];
                    else
                        t4.Image = null;
                    f2Count++;
                }
                else if (stack4[countStack4].Tag.ToString().Contains("hearts") && stack4[countStack4].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack4[countStack4];
                    countStack4--;
                    if (countStack4 >= 0)
                        t4.Image = stack4[countStack4];
                    else
                        t4.Image = null;
                    f3Count++;
                }
                else if (stack4[countStack4].Tag.ToString().Contains("spades") && stack4[countStack4].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack4[countStack4];
                    countStack4--;
                    if (countStack4 >= 0)
                        t4.Image = stack4[countStack4];
                    else
                        t4.Image = null;
                    f4Count++;
                }
            }
        }
        private void t5_Click(object sender, EventArgs e)
        {
            if (countStack5 >= 0)
            {
                if (stack5[countStack5].Tag.ToString().Contains("clubs") && stack5[countStack5].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack5[countStack5];
                    countStack5--;
                    if (countStack5 >= 0)
                        t5.Image = stack5[countStack5];
                    else
                        t5.Image = null;
                    f1Count++;
                }
                else if (stack5[countStack5].Tag.ToString().Contains("diamonds") && stack5[countStack5].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack5[countStack5];
                    countStack5--;
                    if (countStack5 >= 0)
                        t5.Image = stack5[countStack5];
                    else
                        t5.Image = null;
                    f2Count++;
                }
                else if (stack5[countStack5].Tag.ToString().Contains("hearts") && stack5[countStack5].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack5[countStack5];
                    countStack5--;
                    if (countStack5 >= 0)
                        t5.Image = stack5[countStack5];
                    else
                        t5.Image = null;
                    f3Count++;
                }
                else if (stack5[countStack5].Tag.ToString().Contains("spades") && stack5[countStack5].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack5[countStack5];
                    countStack5--;
                    if (countStack5 >= 0)
                        t5.Image = stack5[countStack5];
                    else
                        t5.Image = null;
                    f4Count++;
                }
            }
        }
        private void t6_Click(object sender, EventArgs e)
        {
            if (countStack6 >= 0)
            {
                if (stack6[countStack6].Tag.ToString().Contains("clubs") && stack6[countStack6].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack6[countStack6];
                    countStack6--;
                    if (countStack6 >= 0)
                        t6.Image = stack6[countStack6];
                    else
                        t6.Image = null;
                    f1Count++;
                }
                else if (stack6[countStack6].Tag.ToString().Contains("diamonds") && stack6[countStack6].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack6[countStack6];
                    countStack6--;
                    if (countStack6 >= 0)
                        t6.Image = stack6[countStack6];
                    else
                        t6.Image = null;
                    f2Count++;
                }
                else if (stack6[countStack6].Tag.ToString().Contains("hearts") && stack6[countStack6].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack6[countStack6];
                    countStack6--;
                    if (countStack6 >= 0)
                        t6.Image = stack6[countStack6];
                    else
                        t6.Image = null;
                    f3Count++;
                }
                else if (stack6[countStack6].Tag.ToString().Contains("spades") && stack6[countStack6].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack6[countStack6];
                    countStack6--;
                    if (countStack6 >= 0)
                        t6.Image = stack6[countStack6];
                    else
                        t6.Image = null;
                    f4Count++;
                }
            }
        }
        private void t7_Click(object sender, EventArgs e)
        {
            if (countStack7 >= 0)
            {
                if (stack7[countStack7].Tag.ToString().Contains("clubs") && stack7[countStack7].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack7[countStack7];
                    countStack7--;
                    if (countStack7 >= 0)
                        t7.Image = stack7[countStack7];
                    else
                        t7.Image = null;
                    f1Count++;
                }
                else if (stack7[countStack7].Tag.ToString().Contains("diamonds") && stack7[countStack7].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack7[countStack7];
                    countStack7--;
                    if (countStack7 >= 0)
                        t7.Image = stack7[countStack7];
                    else
                        t7.Image = null;
                    f2Count++;
                }
                else if (stack7[countStack7].Tag.ToString().Contains("hearts") && stack7[countStack7].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack7[countStack7];
                    countStack7--;
                    if (countStack7 >= 0)
                        t7.Image = stack7[countStack7];
                    else
                        t7.Image = null;
                    f3Count++;
                }
                else if (stack7[countStack7].Tag.ToString().Contains("spades") && stack7[countStack7].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack7[countStack7];
                    countStack7--;
                    if (countStack7 >= 0)
                        t7.Image = stack7[countStack7];
                    else
                        t7.Image = null;
                    f4Count++;
                }
            }
        }
        private void t8_Click(object sender, EventArgs e)
        {
            if (countStack8 >= 0)
            {
                if (stack8[countStack8].Tag.ToString().Contains("clubs") && stack8[countStack8].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack8[countStack8];
                    countStack8--;
                    if (countStack8 >= 0)
                        t8.Image = stack8[countStack8];
                    else
                        t8.Image = null;
                    f1Count++;
                }
                else if (stack8[countStack8].Tag.ToString().Contains("diamonds") && stack8[countStack8].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack8[countStack8];
                    countStack8--;
                    if (countStack8 >= 0)
                        t8.Image = stack8[countStack8];
                    else
                        t8.Image = null;
                    f2Count++;
                }
                else if (stack8[countStack8].Tag.ToString().Contains("hearts") && stack8[countStack8].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack8[countStack8];
                    countStack8--;
                    if (countStack8 >= 0)
                        t8.Image = stack8[countStack8];
                    else
                        t8.Image = null;
                    f3Count++;
                }
                else if (stack8[countStack8].Tag.ToString().Contains("spades") && stack8[countStack8].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack8[countStack8];
                    countStack8--;
                    if (countStack8 >= 0)
                        t8.Image = stack8[countStack8];
                    else
                        t8.Image = null;
                    f4Count++;
                }
            }
        }
        private void t9_Click(object sender, EventArgs e)
        {
            if (countStack9 >= 0)
            {
                if (stack9[countStack9].Tag.ToString().Contains("clubs") && stack9[countStack9].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack9[countStack9];
                    countStack9--;
                    if (countStack9 >= 0)
                        t9.Image = stack9[countStack9];
                    else
                        t9.Image = null;
                    f1Count++;
                }
                else if (stack9[countStack9].Tag.ToString().Contains("diamonds") && stack9[countStack9].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack9[countStack9];
                    countStack9--;
                    if (countStack9 >= 0)
                        t9.Image = stack9[countStack9];
                    else
                        t9.Image = null;
                    f2Count++;
                }
                else if (stack9[countStack9].Tag.ToString().Contains("hearts") && stack9[countStack9].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack9[countStack9];
                    countStack9--;
                    if (countStack9 >= 0)
                        t9.Image = stack9[countStack9];
                    else
                        t9.Image = null;
                    f3Count++;
                }
                else if (stack9[countStack9].Tag.ToString().Contains("spades") && stack9[countStack9].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack9[countStack9];
                    countStack9--;
                    if (countStack9 >= 0)
                        t9.Image = stack9[countStack9];
                    else
                        t9.Image = null;
                    f4Count++;
                }
            }
        }
        private void t10_Click(object sender, EventArgs e)
        {
            if (countStack10 >= 0)
            {
                if (stack10[countStack10].Tag.ToString().Contains("clubs") && stack10[countStack10].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack10[countStack10];
                    countStack10--;
                    if (countStack10 >= 0)
                        t10.Image = stack10[countStack10];
                    else
                        t10.Image = null;
                    f1Count++;
                }
                else if (stack10[countStack10].Tag.ToString().Contains("diamonds") && stack10[countStack10].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack10[countStack10];
                    countStack10--;
                    if (countStack10 >= 0)
                        t10.Image = stack10[countStack10];
                    else
                        t10.Image = null;
                    f2Count++;
                }
                else if (stack10[countStack10].Tag.ToString().Contains("hearts") && stack10[countStack10].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack10[countStack10];
                    countStack10--;
                    if (countStack10 >= 0)
                        t10.Image = stack10[countStack10];
                    else
                        t10.Image = null;
                    f3Count++;
                }
                else if (stack10[countStack10].Tag.ToString().Contains("spades") && stack10[countStack10].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack10[countStack10];
                    countStack10--;
                    if (countStack10 >= 0)
                        t10.Image = stack10[countStack10];
                    else
                        t10.Image = null;
                    f4Count++;
                }
            }
        }
        private void t11_Click(object sender, EventArgs e)
        {
            if (countStack11 >= 0)
            {
                if (stack11[countStack11].Tag.ToString().Contains("clubs") && stack11[countStack11].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack11[countStack11];
                    countStack11--;
                    if (countStack11 >= 0)
                        t11.Image = stack11[countStack11];
                    else
                        t11.Image = null;
                    f1Count++;
                }
                else if (stack11[countStack11].Tag.ToString().Contains("diamonds") && stack11[countStack11].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack11[countStack11];
                    countStack11--;
                    if (countStack11 >= 0)
                        t11.Image = stack11[countStack11];
                    else
                        t11.Image = null;
                    f2Count++;
                }
                else if (stack11[countStack11].Tag.ToString().Contains("hearts") && stack11[countStack11].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack11[countStack11];
                    countStack11--;
                    if (countStack11 >= 0)
                        t11.Image = stack11[countStack11];
                    else
                        t11.Image = null;
                    f3Count++;
                }
                else if (stack11[countStack11].Tag.ToString().Contains("spades") && stack11[countStack11].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack11[countStack11];
                    countStack11--;
                    if (countStack11 >= 0)
                        t11.Image = stack11[countStack11];
                    else
                        t11.Image = null;
                    f4Count++;
                }
            }
        }
        private void t12_Click(object sender, EventArgs e)
        {
            if (countStack12 >= 0)
            {
                if (stack12[countStack12].Tag.ToString().Contains("clubs") && stack12[countStack12].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack12[countStack12];
                    countStack12--;
                    if (countStack12 >= 0)
                        t12.Image = stack12[countStack12];
                    else
                        t12.Image = null;
                    f1Count++;
                }
                else if (stack12[countStack12].Tag.ToString().Contains("diamonds") && stack12[countStack12].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack12[countStack12];
                    countStack12--;
                    if (countStack12 >= 0)
                        t12.Image = stack12[countStack12];
                    else
                        t12.Image = null;
                    f2Count++;
                }
                else if (stack12[countStack12].Tag.ToString().Contains("hearts") && stack12[countStack12].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack12[countStack12];
                    countStack12--;
                    if (countStack12 >= 0)
                        t12.Image = stack12[countStack12];
                    else
                        t12.Image = null;
                    f3Count++;
                }
                else if (stack12[countStack12].Tag.ToString().Contains("spades") && stack12[countStack12].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack12[countStack12];
                    countStack12--;
                    if (countStack12 >= 0)
                        t12.Image = stack12[countStack12];
                    else
                        t12.Image = null;
                    f4Count++;
                }
            }
        }
        private void t13_Click(object sender, EventArgs e)
        {
            if (countStack13 >= 0)
            {
                if (stack13[countStack13].Tag.ToString().Contains("clubs") && stack13[countStack13].Tag.ToString() == f1Stack[f1Count])
                {
                    f1.Image = stack13[countStack13];
                    countStack13--;
                    if (countStack13 >= 0)
                        t13.Image = stack13[countStack13];
                    else
                        t13.Image = null;
                    f1Count++;
                }
                else if (stack13[countStack13].Tag.ToString().Contains("diamonds") && stack13[countStack13].Tag.ToString() == f2Stack[f2Count])
                {
                    f2.Image = stack13[countStack13];
                    countStack13--;
                    if (countStack13 >= 0)
                        t13.Image = stack13[countStack13];
                    else
                        t13.Image = null;
                    f2Count++;
                }
                else if (stack13[countStack13].Tag.ToString().Contains("hearts") && stack13[countStack13].Tag.ToString() == f3Stack[f3Count])
                {
                    f3.Image = stack13[countStack13];
                    countStack13--;
                    if (countStack13 >= 0)
                        t13.Image = stack13[countStack13];
                    else
                        t13.Image = null;
                    f3Count++;
                }
                else if (stack13[countStack13].Tag.ToString().Contains("spades") && stack13[countStack13].Tag.ToString() == f4Stack[f4Count])
                {
                    f4.Image = stack13[countStack13];
                    countStack13--;
                    if (countStack13 >= 0)
                        t13.Image = stack13[countStack13];
                    else
                        t13.Image = null;
                    f4Count++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateCards();
            populateFstacks();
            //Put the kings in the stacks
            stack1[0] = cards[44];
            stack6[0] = cards[45];
            stack9[0] = cards[46];
            stack12[0] = cards[47];
            stack3[0] = cards[0];
            array[0] = 44;
            array[1] = 45;
            array[2] = 46;
            array[3] = 47;
            arrayCount = 5;
            stack1 = populateStacks(stack1);
            stack2 = populateStacks(stack2);
            stack3 = populateStacks(stack3);
            stack4 = populateStacks(stack4);
            stack5 = populateStacks(stack5);
            stack6 = populateStacks(stack6);
            stack7 = populateStacks(stack7);
            stack8 = populateStacks(stack8);
            stack9 = populateStacks(stack9);
            stack10 = populateStacks(stack10);
            stack11 = populateStacks(stack11);
            stack12 = populateStacks(stack12);
            stack13 = populateStacks(stack13);
            populatePictures();
            countStack1 = 3;
            countStack2 = 3;
            countStack3 = 3;
            countStack4 = 3;
            countStack5 = 3;
            countStack6 = 3;
            countStack7 = 3;
            countStack8 = 3;
            countStack9 = 3;
            countStack10 = 3;
            countStack11 = 3;
            countStack12 = 3;
            countStack13 = 3;
            f1Count = 0;
            f2Count = 0;
            f3Count = 0;
            f4Count = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class Form3 : Form
    {
       int move;
        int x;
        int y;
        public Form3()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtPrawnSpecial.Text = "0";

            txtChilliChicken.Text = "0";

            txthotandsour.Text = "0";

            txtZingerBurger.Text = "0";

            txtChickenBurger.Text = "0";

            txtClubSandwich.Text = "0";

            txtBeefBurger.Text = "0";

            txtChickenBiryani.Text = "0";

            txtChickenPulao.Text = "0";

            txtBeefBiryani.Text = "0";

            txtMuttonPulao.Text = "0";

            txtChickenSajji.Text = "0";

            txtChickenSajjiandRice.Text = "0";

            txtMuttonSajji.Text = "0";

            txtMuttonSajjiandRice.Text = "0";

            txtChoclate.Text = "0";

            txtStrawberry.Text = "0";

            txtTuttyFruity.Text = "0";

            txtOreoandMadness.Text = "0";

            txtSprite.Text = "0";

            txtMineralWater.Text = "0";

            txtJuice.Text = "0";

            txtBananaShake.Text = "0";

            labelServiceCharge.Text = "1.70";

            labelSubTotal.Text = "0";

            labelTotal.Text = "0";

            checkPrawnSpecial.Checked = false;

            checkChilliChicken.Checked = false;

            checkHotandSour.Checked = false;

            checkZingerBurger.Checked = false;

            checkChickenBurger.Checked = false;

            checkClubSanwich.Checked = false;

            checkBeefburger.Checked = false;

            checkChickenBiryani.Checked = false;

            checkChickenPulao.Checked = false;

            checkBeefBiryani.Checked = false;

            checkMuttonPulao.Checked = false;

            checkChikenSajji.Checked = false;

            checkChickenSajjiandRice.Checked = false;

            checkMuttonSajji.Checked = false;

            checkMuttonSajjiandRice.Checked = false;

            checkChoclate.Checked = false;

            checkStrawbery.Checked = false;

            checkTuttyFruity.Checked = false;

            checkOreoandMadness.Checked = false;

            checkSprite.Checked = false;

            checkMineralWater.Checked = false;

            checkJuice.Checked = false;

            checkBananaShake.Checked = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();

            timer1.Start();

            txtPrawnSpecial.Text = "0";

            txtChilliChicken.Text = "0";

            txthotandsour.Text = "0";

            txtZingerBurger.Text = "0";

            txtChickenBurger.Text = "0";

            txtClubSandwich.Text = "0";

            txtBeefBurger.Text = "0";

            txtChickenBiryani.Text = "0";

            txtChickenPulao.Text = "0";

            txtBeefBiryani.Text = "0";

            txtMuttonPulao.Text = "0";

            txtChickenSajji.Text = "0";

            txtChickenSajjiandRice.Text = "0";

            txtMuttonSajji.Text = "0";

            txtMuttonSajjiandRice.Text = "0";

            txtChoclate.Text = "0";

            txtStrawberry.Text = "0";

            txtTuttyFruity.Text = "0";

            txtOreoandMadness.Text = "0";

            txtSprite.Text = "0";

            txtMineralWater.Text = "0";

            txtJuice.Text = "0";

            txtBananaShake.Text = "0";

            labelServiceCharge.Text = "1.70";

            labelSubTotal.Text = "0";

            labelTotal.Text = "0";
            // ENABLED FALSE
            txtPrawnSpecial.Enabled = false;

            txtChilliChicken.Enabled = false;

            txthotandsour.Enabled = false;

            txtZingerBurger.Enabled = false;

            txtChickenBurger.Enabled = false;

            txtClubSandwich.Enabled = false;

            txtBeefBurger.Enabled = false;

            txtChickenBiryani.Enabled = false;

            txtChickenPulao.Enabled = false;

            txtBeefBiryani.Enabled = false;

            txtMuttonPulao.Enabled = false;

            txtChickenSajji.Enabled = false;

            txtChickenSajjiandRice.Enabled = false;

            txtMuttonSajji.Enabled = false;

            txtMuttonSajjiandRice.Enabled = false;

            txtChoclate.Enabled = false;

            txtStrawberry.Enabled = false;

            txtTuttyFruity.Enabled = false;

            txtOreoandMadness.Enabled = false;

            txtSprite.Enabled = false;

            txtMineralWater.Enabled = false;

            txtJuice.Enabled = false;

            txtBananaShake.Enabled = false;

            checkPrawnSpecial.Checked = false;

            checkChilliChicken.Checked = false;

            checkHotandSour.Checked = false;

            checkZingerBurger.Checked = false;

            checkChickenBurger.Checked = false;

            checkClubSanwich.Checked = false;

            checkBeefburger.Checked = false;

            checkChickenBiryani.Checked = false;

            checkChickenPulao.Checked = false;

            checkBeefBiryani.Checked = false;

            checkMuttonPulao.Checked = false;

            checkChikenSajji.Checked = false;

            checkChickenSajjiandRice.Checked = false;

            checkMuttonSajji.Checked = false;

            checkMuttonSajjiandRice.Checked = false;

            checkChoclate.Checked = false;

            checkStrawbery.Checked = false;

            checkTuttyFruity.Checked = false;

            checkOreoandMadness.Checked = false;

            checkSprite.Checked = false;

            checkMineralWater.Checked = false;

            checkJuice.Checked = false;

            checkBananaShake.Checked = false;
        }

        private void checkPrawnSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrawnSpecial.Checked == true)
            {
                txtPrawnSpecial.Enabled = true;
            }

            if (checkPrawnSpecial.Checked == false)
            {
                txtPrawnSpecial.Enabled = false;
                txtPrawnSpecial.Text = "0";
            }
        }

        private void txtPrawnSpecial_Click_1(object sender, EventArgs e)
        {
            txtPrawnSpecial.Text = "";
            txtPrawnSpecial.Focus();
        }


        private void checkChilliChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChilliChicken.Checked == true)
            {
                txtChilliChicken.Enabled = true;
            }

            if (checkChilliChicken.Checked == false)
            {
                txtChilliChicken.Enabled = false;
                txtChilliChicken.Text = "0";
            }
        }

        private void txtChilliChicken_Click(object sender, EventArgs e)
        {
            txtChilliChicken.Text = "";
            txtChilliChicken.Focus();
        }

        private void checkHotandSour_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHotandSour.Checked == true)
            {
                txthotandsour.Enabled = true;
            }

            if (checkHotandSour.Checked == false)
            {
                txthotandsour.Enabled = false;
                txthotandsour.Text = "0";
            }
        }

        private void txthotandsour_Click(object sender, EventArgs e)
        {
            txthotandsour.Text = "";
            txthotandsour.Focus();
        }

        private void checkZingerBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkZingerBurger.Checked == true)
            {
                txtZingerBurger.Enabled = true;
            }

            if (checkZingerBurger.Checked == false)
            {
                txtZingerBurger.Enabled = false;
                txtZingerBurger.Text = "0";
            }
        }

        private void txtZingerBurger_Click(object sender, EventArgs e)
        {
            txtZingerBurger.Text = "";
            txtZingerBurger.Focus();
        }

        private void checkChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChickenBurger.Checked == true)
            {
                txtChickenBurger.Enabled = true;
            }

            if (checkChickenBurger.Checked == false)
            {
                txtChickenBurger.Enabled = false;
                txtChickenBurger.Text = "0";
            }
        }

        private void txtChickenBurger_Click(object sender, EventArgs e)
        {
            txtChickenBurger.Text = "";
            txtChickenBurger.Focus();
        }

        private void checkClubSanwich_CheckedChanged(object sender, EventArgs e)
        {
            if (checkClubSanwich.Checked == true)
            {
                txtClubSandwich.Enabled = true;
            }

            if (checkClubSanwich.Checked == false)
            {
                txtClubSandwich.Enabled = false;
                txtClubSandwich.Text = "0";
            }
        }

        private void txtClubSandwich_Click(object sender, EventArgs e)
        {
            txtClubSandwich.Text = "";
            txtClubSandwich.Focus();
        }

        private void checkBeefburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBeefburger.Checked == true)
            {
                txtBeefBurger.Enabled = true;
            }

            if (checkBeefburger.Checked == false)
            {
                txtBeefBurger.Enabled = false;
                txtBeefBurger.Text = "0";
            }
        }

        private void txtBeefBurger_Click(object sender, EventArgs e)
        {
            txtBeefBurger.Text = "";
            txtBeefBurger.Focus();
        }

        private void checkChickenBiryani_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChickenBiryani.Checked == true)
            {
                txtChickenBiryani.Enabled = true;
            }

            if (checkChickenBiryani.Checked == false)
            {
                txtChickenBiryani.Enabled = false;
                txtChickenBiryani.Text = "0";
            }
        }

        private void txtChickenBiryani_Click(object sender, EventArgs e)
        {
            txtChickenBiryani.Text = "";
            txtChickenBiryani.Focus();
        }

        private void checkChickenPulao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChickenPulao.Checked == true)
            {
                txtChickenPulao.Enabled = true;
            }

            if (checkChickenPulao.Checked == false)
            {
                txtChickenPulao.Enabled = false;
                txtChickenPulao.Text = "0";
            }
        }

        private void txtChickenPulao_Click(object sender, EventArgs e)
        {
            txtChickenPulao.Text = "";
            txtChickenPulao.Focus();
        }

        private void checkBeefBiryani_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBeefBiryani.Checked == true)
            {
                txtBeefBiryani.Enabled = true;
            }

            if (checkBeefBiryani.Checked == false)
            {
                txtBeefBiryani.Enabled = false;
                txtBeefBiryani.Text = "0";
            }
        }

        private void txtBeefBiryani_Click(object sender, EventArgs e)
        {
            txtBeefBiryani.Text = "";
            txtBeefBiryani.Focus();
        }

        private void checkMuttonPulao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMuttonPulao.Checked == true)
            {
                txtMuttonPulao.Enabled = true;
            }

            if (checkMuttonPulao.Checked == false)
            {
                txtMuttonPulao.Enabled = false;
                txtMuttonPulao.Text = "0";
            }
        }

        private void txtMuttonPulao_Click(object sender, EventArgs e)
        {
            txtMuttonPulao.Text = "";
            txtMuttonPulao.Focus();
        }

        private void checkChikenSajji_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChikenSajji.Checked == true)
            {
                txtChickenSajji.Enabled = true;
            }

            if (checkChikenSajji.Checked == false)
            {
                txtChickenSajji.Enabled = false;
                txtChickenSajji.Text = "0";
            }
        }

        private void txtChickenSajji_Click(object sender, EventArgs e)
        {
            txtChickenSajji.Text = "";
            txtChickenSajji.Focus();
        }

        private void checkChickenSajjiandRice_CheckedChanged(object sender, EventArgs e)
        {

            if (checkChickenSajjiandRice.Checked == true)
            {
                txtChickenSajjiandRice.Enabled = true;
            }

            if (checkChickenSajjiandRice.Checked == false)
            {
                txtChickenSajjiandRice.Enabled = false;
                txtChickenSajjiandRice.Text = "0";
            }
        }

        private void txtChickenSajjiandRice_Click(object sender, EventArgs e)
        {
            txtChickenSajjiandRice.Text = "";
            txtChickenSajjiandRice.Focus();
        }

        private void checkMuttonSajji_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMuttonSajji.Checked == true)
            {
                txtMuttonSajji.Enabled = true;
            }

            if (checkMuttonSajji.Checked == false)
            {
                txtMuttonSajji.Enabled = false;
                txtMuttonSajji.Text = "0";
            }
        }

        private void txtMuttonSajji_Click(object sender, EventArgs e)
        {
            txtMuttonSajji.Text = "";
            txtMuttonSajji.Focus();
        }

        private void checkMuttonSajjiandRice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMuttonSajjiandRice.Checked == true)
            {
                txtMuttonSajjiandRice.Enabled = true;
            }

            if (checkMuttonSajjiandRice.Checked == false)
            {
                txtMuttonSajjiandRice.Enabled = false;
                txtMuttonSajjiandRice.Text = "0";
            }
        }

        private void txtMuttonSajjiandRice_Click(object sender, EventArgs e)
        {
            txtMuttonSajjiandRice.Text = "";
            txtMuttonSajjiandRice.Focus();
        }

        private void checkChoclate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChoclate.Checked == true)
            {
                txtChoclate.Enabled = true;
            }

            if (checkChoclate.Checked == false)
            {
                txtChoclate.Enabled = false;
                txtChoclate.Text = "0";
            }
        }

        private void txtChoclate_Click(object sender, EventArgs e)
        {
            txtChoclate.Text = "";
            txtChoclate.Focus();
        }

        private void checkStrawbery_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStrawbery.Checked == true)
            {
                txtStrawberry.Enabled = true;
            }

            if (checkStrawbery.Checked == false)
            {
                txtStrawberry.Enabled = false;
                txtStrawberry.Text = "0";
            }
        }

        private void txtStrawberry_Click(object sender, EventArgs e)
        {
            txtStrawberry.Text = "";
            txtStrawberry.Focus();
        }

        private void checkTuttyFruity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTuttyFruity.Checked == true)
            {
                txtTuttyFruity.Enabled = true;
            }

            if (checkTuttyFruity.Checked == false)
            {
                txtTuttyFruity.Enabled = false;
                txtTuttyFruity.Text = "0";
            }
        }

        private void txtTuttyFruity_Click(object sender, EventArgs e)
        {
            txtTuttyFruity.Text = "";
            txtTuttyFruity.Focus();
        }

        private void checkOreoandMadness_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOreoandMadness.Checked == true)
            {
                txtOreoandMadness.Enabled = true;
            }

            if (checkOreoandMadness.Checked == false)
            {
                txtOreoandMadness.Enabled = false;
                txtOreoandMadness.Text = "0";
            }
        }

        private void txtOreoandMadness_Click(object sender, EventArgs e)
        {
            txtOreoandMadness.Text = "";
            txtOreoandMadness.Focus();
        }

        private void checkSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSprite.Checked == true)
            {
                txtSprite.Enabled = true;
            }

            if (checkSprite.Checked == false)
            {
                txtSprite.Enabled = false;
                txtSprite.Text = "0";
            }
        }

        private void txtSprite_Click(object sender, EventArgs e)
        {
            txtSprite.Text = "";
            txtSprite.Focus();
        }

        private void checkMineralWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMineralWater.Checked == true)
            {
                txtMineralWater.Enabled = true;
            }

            if (checkMineralWater.Checked == false)
            {
                txtMineralWater.Enabled = false;
                txtMineralWater.Text = "0";
            }
        }

        private void txtMineralWater_Click(object sender, EventArgs e)
        {
            txtMineralWater.Text = "";
            txtMineralWater.Focus();
        }

        private void checkJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJuice.Checked == true)
            {
                txtJuice.Enabled = true;
            }

            if (checkJuice.Checked == false)
            {
                txtJuice.Enabled = false;
                txtJuice.Text = "0";
            }
        }

        private void txtJuice_Click(object sender, EventArgs e)
        {
            txtJuice.Text = "";
            txtJuice.Focus();
        }

        private void checkBananaShake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBananaShake.Checked == true)
            {
                txtBananaShake.Enabled = true;
            }

            if (checkBananaShake.Checked == false)
            {
                txtBananaShake.Enabled = false;
                txtBananaShake.Text = "0";
            }
        }

        private void txtBananaShake_Click(object sender, EventArgs e)
        {
            txtBananaShake.Text = "";
            txtBananaShake.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rftreciept.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rftreciept.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rftreciept.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rftreciept.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rftreciept.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.txt)|*.txt|Allfiles(*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rftreciept.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Notepad Text";
            save.Filter = "Text Files(*.txt)|*.txt|Allfiles(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName))
                    sw.WriteLine(rftreciept.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rftreciept.Clear();

            rftreciept.AppendText(Environment.NewLine);

            rftreciept.AppendText("\t\t\t" + "Just Do Resturant" + Environment.NewLine);

            rftreciept.AppendText("--------------------------------------" + Environment.NewLine + Environment.NewLine);

            rftreciept.AppendText("PrawnSpecial\t\t" + txtPrawnSpecial.Text + Environment.NewLine);

            rftreciept.AppendText("ChilliChicken\t\t" + txtChilliChicken.Text + Environment.NewLine);

            rftreciept.AppendText("hotandsour\t\t" + txthotandsour.Text + Environment.NewLine);

            rftreciept.AppendText("ZingerBurger\t\t" + txtZingerBurger.Text + Environment.NewLine);

            rftreciept.AppendText("ChickenBurger\t\t" + txtChickenBurger.Text + Environment.NewLine);

            rftreciept.AppendText("ClubSandwich\t\t" + txtClubSandwich.Text + Environment.NewLine);

            rftreciept.AppendText("BeefBurger\t\t" + txtBeefBurger.Text + Environment.NewLine);

            rftreciept.AppendText("ChickenBiryani\t\t" + txtChickenBiryani.Text + Environment.NewLine);

            rftreciept.AppendText("ChickenPulao\t\t" + txtChickenPulao.Text + Environment.NewLine);

            rftreciept.AppendText("BeefBiryani\t\t" + txtBeefBiryani.Text + Environment.NewLine);

            rftreciept.AppendText("MuttonPulao\t\t" + txtMuttonPulao.Text + Environment.NewLine);

            rftreciept.AppendText("ChickenSajji\t\t" + txtChickenSajji.Text + Environment.NewLine);

            rftreciept.AppendText("ChickenSajjiandRice\t\t" + txtChickenSajjiandRice.Text + Environment.NewLine);

            rftreciept.AppendText("MuttonSajji\t\t" + txtMuttonSajji.Text + Environment.NewLine);

            rftreciept.AppendText("MuttonSajjiandRice\t\t" + txtMuttonSajjiandRice.Text + Environment.NewLine);

            rftreciept.AppendText("Choclate\t\t" + txtChoclate.Text + Environment.NewLine);

            rftreciept.AppendText("Strawberry\t\t" + txtStrawberry.Text + Environment.NewLine);

            rftreciept.AppendText("TuttyFruity\t\t" + txtTuttyFruity.Text + Environment.NewLine);

            rftreciept.AppendText("OreoandMadness\t\t" + txtOreoandMadness.Text + Environment.NewLine);

            rftreciept.AppendText("Sprite\t\t" + txtSprite.Text + Environment.NewLine);

            rftreciept.AppendText("MineralWater\t\t" + txtMineralWater.Text + Environment.NewLine);

            rftreciept.AppendText("Juice\t\t" + txtJuice.Text + Environment.NewLine);

            rftreciept.AppendText("BananaShake\t\t" + txtBananaShake.Text + Environment.NewLine);

            rftreciept.AppendText("--------------------------------------------" + Environment.NewLine);

            rftreciept.AppendText("ServiceCharge\t\t" + labelServiceCharge.Text + Environment.NewLine);

            rftreciept.AppendText("SubTotal\t\t" + labelSubTotal.Text + Environment.NewLine);

            rftreciept.AppendText("Total\t\t" + labelTotal.Text + Environment.NewLine);

            rftreciept.AppendText("--------------------------------------------" + Environment.NewLine);

            rftreciept.AppendText(label8.Text + "\t\t\t\t" + label7.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tax ;
            tax = 0.45;
            double PrawnSpecial, ChilliChicken, Hotandsour,
                  ZingerBurger, ChickenBurger, ClubSandwich, BeefBurger,
                  ChickenBiryani, ChickenPulao, BeefBiryani, MuttonPulao,
                  ChickenSajji, ChickenSajjiandRice, MuttonSajji, MuttonSajjiandRice,
                  Choclate, Strawberry, TuutyFruity, OreoandMadness,
                  Sprite, MineralWater, Juice, BananaShake;

            PrawnSpecial = 120.0; ChilliChicken = 120.0; Hotandsour = 210.0;
            ZingerBurger = 120.0; ChickenBurger = 115.0; ClubSandwich = 80.0; BeefBurger = 98.0;
            ChickenBiryani = 130.0; ChickenPulao = 120.0; BeefBiryani = 110.0; MuttonPulao = 150.0;
            ChickenSajji = 200.0; ChickenSajjiandRice = 280.0; MuttonSajji = 290.0; MuttonSajjiandRice = 300.0;
            Choclate = 150.0; Strawberry = 150.0; TuutyFruity = 150.0; OreoandMadness = 150.0;
            Sprite = 120.0; MineralWater = 120.0; Juice = 120.0; BananaShake = 120.0;
            //Soup
            double Prawn= Convert.ToDouble(txtPrawnSpecial.Text);

            double Chilli= Convert.ToDouble(txtChilliChicken.Text);

            double Sour= Convert.ToDouble(txthotandsour.Text);
            //Burger
            double Zinger= Convert.ToDouble(txtZingerBurger.Text);

            double ChickenBurgers= Convert.ToDouble(txtChickenBurger.Text);

            double Sandwich= Convert.ToDouble(txtClubSandwich.Text);

            double Beefburgers= Convert.ToDouble(txtBeefBiryani.Text);
            //Rice
            double BiryaniChicken= Convert.ToDouble(txtChickenBiryani.Text);

            double PulaoChicken = Convert.ToDouble(txtChickenPulao.Text);

            double Biryanibeef = Convert.ToDouble(txtBeefBiryani.Text);

            double PulaoMutton = Convert.ToDouble(txtMuttonPulao.Text);
            //Sajji
            double SajjiChicken = Convert.ToDouble(txtChickenSajji.Text);

            double SajjiChickenandRice = Convert.ToDouble(txtChickenSajjiandRice.Text);

            double SajjiMutton = Convert.ToDouble(txtMuttonSajji.Text);

            double SajjiMuttonandRice = Convert.ToDouble(txtMuttonSajjiandRice.Text);
            //Ice-cream
            double Choco = Convert.ToDouble(txtChoclate.Text);

            double Strawberries = Convert.ToDouble(txtStrawberry.Text);

            double TuttyFruityy = Convert.ToDouble(txtTuttyFruity.Text);

            double Oreo = Convert.ToDouble(txtOreoandMadness.Text);
            // ColdDrink
            double Colddrink = Convert.ToDouble(txtSprite.Text);

            double Water = Convert.ToDouble(txtMineralWater.Text);

            double Juices = Convert.ToDouble(txtJuice.Text);

            double Shake = Convert.ToDouble(txtBananaShake.Text);

            RMS resturant = new RMS(Prawn, Chilli, Sour ,
                                    Zinger, ChickenBurgers, Sandwich, Beefburgers,
                                    BiryaniChicken, PulaoChicken, BiryaniChicken, PulaoMutton,
                                    SajjiChicken, SajjiChickenandRice, SajjiMutton, SajjiMuttonandRice,
                                    Choco, Strawberries, TuttyFruityy, Oreo,
                                    Colddrink, Water, Juices, Shake);

            double Food = (Prawn * PrawnSpecial) + (Chilli * ChilliChicken) + (Sour * Hotandsour) +
                          (Zinger * ZingerBurger) + (ChickenBurgers * ChickenBurger) + (Sandwich * ClubSandwich) + (Beefburgers * BeefBurger) +
                          (BiryaniChicken * ChickenBiryani)+ (PulaoChicken * ChickenPulao)+ (Biryanibeef  * BeefBiryani) + (PulaoMutton * MuttonPulao) +
                           (SajjiChicken * ChickenSajji) + (SajjiChickenandRice * ChickenSajjiandRice) + (SajjiMutton * MuttonSajji) + (SajjiMuttonandRice * MuttonSajjiandRice) + 
                           (Choco * Choclate) + (Strawberries * Strawberry) + (TuttyFruityy * TuutyFruity) + (Oreo * OreoandMadness) + 
                           (Colddrink * Sprite) + (Water * MineralWater) + (Juices * Juice) + (Shake * BananaShake);

            double Service_charge = Convert.ToDouble(labelServiceCharge.Text);

            labelSubTotal.Text = Convert.ToString(Food + Service_charge);
            LabelTax.Text = Convert.ToString(((Food + Service_charge)*tax)/100);
            double iTax = Convert.ToDouble(LabelTax.Text);
            labelTotal.Text = Convert.ToString(Food + iTax);


        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChickenSajji_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrawnSpecial_TextChanged(object sender, EventArgs e)
        {

        }

      

       

      

    }
}

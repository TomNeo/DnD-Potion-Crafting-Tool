using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Potion_Crafting_Tool
{
    public partial class Form1 : Form
    {
        string CURRENT_STATE = Constants.STATIC_STATE_CRAFT;
        List<Item> Items = new List<Item>();
        List<string> AttributesList = new List<string>();
        List<Item> BaseList = new List<Item>();
        List<string> AddativesList = new List<string>();
        bool SetUp = false;

        public Form1()
        {
            InitializeComponent();
            groupBox1.Text = "" + Constants.GP_PER_LBS_AIR + "GP per LBS";
            groupBox2.Text = "" + Constants.GP_PER_LBS_METAL + "GP per LBS";
            groupBox3.Text = "" + Constants.GP_PER_LBS_ARCANE + "GP per LBS";
            groupBox4.Text = "" + Constants.GP_PER_LBS_INFERNAL + "GP per LBS";
            RankCombo.Items.Clear();
            RankCombo.Items.Add("STARTING");
            RankCombo.Items.Add("BASIC");
            RankCombo.Items.Add("COMMON");
            RankCombo.Items.Add("UNCOMMON");
            RankCombo.Items.Add("RARE");
            RankCombo.Items.Add("VERY_RARE");
            RankCombo.Items.Add("LEGENDARY");
            AttributelistView.HeaderStyle = ColumnHeaderStyle.None;
            setMode(Constants.STATIC_STATE_CRAFT);
            resetLists();
            SetUp = true;
            calculateEssenceWeight(SetUp);
        }

        public void calculateEssenceWeight(bool keepGoing)
        {
            if (keepGoing)
            {
                float finalNumber = 0;
                finalNumber = finalNumber + (float.Parse(Water_Text.Text) / Constants.GP_PER_LBS_WATER);
                finalNumber = finalNumber + (float.Parse(Fire_Text.Text) / Constants.GP_PER_LBS_FIRE);
                finalNumber = finalNumber + (float.Parse(Air_Text.Text) / Constants.GP_PER_LBS_AIR);
                finalNumber = finalNumber + (float.Parse(Nature_Text.Text) / Constants.GP_PER_LBS_NATURE);
                finalNumber = finalNumber + (float.Parse(Metal_Text.Text) / Constants.GP_PER_LBS_METAL);
                finalNumber = finalNumber + (float.Parse(Vitality_Text.Text) / Constants.GP_PER_LBS_VITALITY);
                finalNumber = finalNumber + (float.Parse(Decay_Text.Text) / Constants.GP_PER_LBS_DECAY);
                finalNumber = finalNumber + (float.Parse(Arcane_Text.Text) / Constants.GP_PER_LBS_ARCANE);
                finalNumber = finalNumber + (float.Parse(Divine_Text.Text) / Constants.GP_PER_LBS_DIVINE);
                finalNumber = finalNumber + (float.Parse(Infernal_Text.Text) / Constants.GP_PER_LBS_INFERNAL);
                EssenceWeight.Text = "" + finalNumber;
            }
        }

        public void resetLists()
        {
            Items.Clear();
            ItemsTable.Rows.Clear();
            String[] foundFiles = System.IO.Directory.GetFiles(Constants.DIR_ITEM_FILES);
            foreach (string file in foundFiles)
            {
                Item item = new Item(file);
                Items.Add(item);
                ArrayList newRowItems = new ArrayList();
                newRowItems.Add(item.Name);
                newRowItems.Add(item.Kits);
                newRowItems.Add(item.Rank);
                newRowItems.Add("" + item.Value);
                string tempString = "";
                bool firstTime = true;
                foreach (string attribute in item.Attributes)
                {
                    if (firstTime)
                    {
                        tempString = attribute;
                        firstTime = false;
                    }
                    else
                    {
                        tempString = tempString + "\n" + attribute;
                    }
                    if (!AttributesList.Contains(attribute))
                    {
                        AttributesList.Add(attribute);
                    }
                    if (attribute.Equals(Constants.ITEM_BASE_ATTRIBUTE))
                    {
                        if (!BaseList.Contains(item))
                        {
                            BaseList.Add(item);
                        }
                    }
                }
                newRowItems.Add(tempString);
                newRowItems.Add(item.Base);
                tempString = "";
                firstTime = true;
                foreach (string addative in item.Addatives)
                {
                    if (firstTime)
                    {
                        tempString = addative;
                        firstTime = false;
                    }
                    else
                    {
                        tempString = tempString + "\r\n" + addative;
                    }
                    if (!AddativesList.Contains(addative))
                    {
                        AddativesList.Add(addative);
                    }
                }
                newRowItems.Add(tempString);
                newRowItems.Add("" + item.Water_Value);
                newRowItems.Add("" + item.Fire_Value);
                newRowItems.Add("" + item.Air_Value);
                newRowItems.Add("" + item.Nature_Value);
                newRowItems.Add("" + item.Metal_Value);
                newRowItems.Add("" + item.Vitality_Value);
                newRowItems.Add("" + item.Decay_Value);
                newRowItems.Add("" + item.Arcane_Value);
                newRowItems.Add("" + item.Divine_Value);
                newRowItems.Add("" + item.Infernal_Value);
                ItemsTable.Rows.Add(newRowItems.ToArray());
            }
            BasesCombo.Items.Clear();
            BasesCombo.Items.Add(Constants.STATIC_NONE);
            foreach (Item baseItem in BaseList) 
            {
                BasesCombo.Items.Add(baseItem.Name);
            }
            Addative1Combo.Items.Clear();
            Addative2Combo.Items.Clear();
            Addative1Combo.Items.Add(Constants.STATIC_NONE);
            Addative2Combo.Items.Add(Constants.STATIC_NONE);
            foreach (string addative in AddativesList)
            {
                Addative1Combo.Items.Add(addative);
                Addative2Combo.Items.Add(addative);
            }
            ItemsTable.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            Water_Text.Text = "0";
            Fire_Text.Text = "0";
            Air_Text.Text = "0";
            Nature_Text.Text = "0";
            Metal_Text.Text = "0";
            Vitality_Text.Text = "0";
            Decay_Text.Text = "0";
            Arcane_Text.Text = "0";
            Divine_Text.Text = "0";
            Infernal_Text.Text = "0";
            BasesCombo.SelectedIndex = 0;
            Addative1Combo.SelectedIndex = 0;
            Addative2Combo.SelectedIndex = 0;
            AttributelistView.Items.Clear();
            EffectBox.Text = "";
        }

        private void setMode(string Mode)
        {
                if (Mode.Equals(Constants.STATIC_STATE_EDIT))
                {
                    CURRENT_STATE = Constants.STATIC_STATE_EDIT;
                    this.Text = "Potion Crafting Tool - Edit Mode";
                    ModeButton.Text = "Switch to Craft Mode";
                    ActionButton.Text = "Save!";
                    AlchemyCheck.Enabled = true;
                    PoisonerCheck.Enabled = true;
                    HerbalismCheck.Enabled = true;
                    this.NameText.Enabled = true;
                    this.NameText.Text = " ";
                    addAttribute.Enabled = true;
                    removeAttribute.Enabled = true;
                    newAttributeText.Enabled = true;
                }
                else
                {
                    CURRENT_STATE = Constants.STATIC_STATE_CRAFT;
                    this.Text = "Potion Crafting Tool - Craft Mode";
                    ModeButton.Text = "Switch to Edit Mode";
                    ActionButton.Text = "Craft!";
                    AlchemyCheck.Enabled = false;
                    PoisonerCheck.Enabled = false;
                    HerbalismCheck.Enabled = false;
                    this.NameText.Enabled = false;
                    this.NameText.Text = " ";
                    addAttribute.Enabled = false;
                    removeAttribute.Enabled = false;
                    newAttributeText.Enabled = false;
                }
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (CURRENT_STATE.Equals(Constants.STATIC_STATE_CRAFT))
            {
                setMode(Constants.STATIC_STATE_EDIT);
            }
            else
            {
                setMode(Constants.STATIC_STATE_CRAFT);
            }
        }

        private void Essence_Text_TextChanged(object sender, EventArgs e)
        {
            float test = 0;
            if (((TextBox)sender).Text.Equals(""))
            {
                ((TextBox)sender).Text = "0";
            }
            else if(!float.TryParse(((TextBox)sender).Text,out test)){
                MessageBox.Show("Must be a number value.");
                ((TextBox)sender).Text = "" + test;
            }else if(test < 0)
            {
                MessageBox.Show("Must be a positive number.");
                ((TextBox)sender).Text = "0";
            }
            else
            {
                calculateEssenceWeight(SetUp);
            }
        }

        private void addAttribute_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach(ListViewItem listItem in AttributelistView.Items)
            {
                if (listItem.Text.Equals(newAttributeText.Text.ToUpper()))
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                AttributelistView.Items.Add(newAttributeText.Text.ToUpper());
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (CURRENT_STATE.Equals(Constants.STATIC_STATE_EDIT))
            {
                Item newItem = new Item();
                newItem.Name = this.NameText.Text;
                newItem.Rank = RankCombo.SelectedIndex;
                string tempString = "";
                if (HerbalismCheck.Checked)
                {
                    tempString = tempString + "H";
                }
                if (AlchemyCheck.Checked)
                {
                    tempString = tempString + "A";
                }
                if (PoisonerCheck.Checked)
                {
                    tempString = tempString + "P";
                }
                newItem.Kits = tempString;
                if (!BasesCombo.Items[BasesCombo.SelectedIndex].ToString().Equals(Constants.STATIC_NONE))
                {
                    newItem.Base = BasesCombo.Items[BasesCombo.SelectedIndex].ToString();
                }
                if (!Addative1Combo.Items[Addative1Combo.SelectedIndex].ToString().Equals(Constants.STATIC_NONE))
                {
                    if (!newItem.Addatives.Contains(Addative1Combo.Items[Addative1Combo.SelectedIndex].ToString())) {
                        newItem.Addatives.Add(Addative1Combo.Items[Addative1Combo.SelectedIndex].ToString());
                    }
                }
                if (!Addative2Combo.Items[Addative2Combo.SelectedIndex].ToString().Equals(Constants.STATIC_NONE))
                {
                    if (!newItem.Addatives.Contains(Addative2Combo.Items[Addative2Combo.SelectedIndex].ToString()))
                    {
                        newItem.Addatives.Add(Addative2Combo.Items[Addative2Combo.SelectedIndex].ToString());
                    }
                }
                foreach (ListViewItem listItem in AttributelistView.Items)
                {
                    if (!newItem.Attributes.Contains(listItem.Text))
                    {
                        newItem.Attributes.Add(listItem.Text);
                    }
                }
                newItem.Value = float.Parse(ValueText.Text);
                newItem.Effect = EffectBox.Text;
                newItem.Water_Value = float.Parse(Water_Text.Text);
                newItem.Fire_Value = float.Parse(Fire_Text.Text);
                newItem.Air_Value = float.Parse(Air_Text.Text);
                newItem.Nature_Value = float.Parse(Nature_Text.Text);
                newItem.Metal_Value = float.Parse(Metal_Text.Text);
                newItem.Vitality_Value = float.Parse(Vitality_Text.Text);
                newItem.Decay_Value = float.Parse(Decay_Text.Text);
                newItem.Arcane_Value = float.Parse(Arcane_Text.Text);
                newItem.Divine_Value = float.Parse(Divine_Text.Text);
                newItem.Infernal_Value = float.Parse(Infernal_Text.Text);
                newItem.saveFile();
                resetLists();
            }
            else
            {
                //TO-DO: Take inputs and iterate through the list of possible items and determine the highest value item satisfied by all ingredients
            }
        }
    }
}

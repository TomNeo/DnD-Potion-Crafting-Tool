using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Potion_Crafting_Tool
{
    class Item
    {
        public string Name = "";
        public int Rank = (int)Program.Ranks.BASIC;
        public string Kits = Constants.STATIC_NONE;
        public string Base = Constants.STATIC_NONE;
        public List<string> Addatives = new List<string>();
        public List<string> Attributes = new List<string>();
        public float Value = 0f;
        public string Effect = "";
        public float Water_Value = 0f;
        public float Fire_Value = 0f;
        public float Air_Value = 0f;
        public float Nature_Value = 0f;
        public float Metal_Value = 0f;
        public float Vitality_Value = 0f;
        public float Decay_Value = 0f;
        public float Arcane_Value = 0f;
        public float Divine_Value = 0f;
        public float Infernal_Value = 0f;

        public Item(String filePath)
        {
            string[] pathElements = filePath.Split('\\');
            Name = pathElements[pathElements.Length-1].Split(new string[] { ".txt" }, StringSplitOptions.None)[0];
            List<string> FileLines = Program.TOOLS.readFile(filePath);
            foreach(string line in FileLines)
            {
                string[] LineBits = line.Split(new string[] { Constants.FILE_HEADER_SEPARATOR }, StringSplitOptions.None);
                if (LineBits[0].Equals(Constants.ITEM_RANK_HEADER))
                {
                    Rank = int.Parse(LineBits[1].Trim());
                } else if (LineBits[0].Equals(Constants.ITEM_KITS_HEADER)){
                    Kits = LineBits[1].Trim();
                }
                else if (LineBits[0].Equals(Constants.ITEM_BASE_HEADER) ){
                    Base = LineBits[1].Trim();
                }
                else if (LineBits[0].Equals(Constants.ITEM_ADDATIVE_HEADER) ){
                    Addatives.Add(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_ATTRIBUTES_HEADER) ){
                    Attributes.Add(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_VALUE_HEADER) ){
                    Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_EFFECT_HEADER) ){
                    Effect = LineBits[1].Trim();
                }
                else if (LineBits[0].Equals(Constants.ITEM_WATER_HEADER) ){
                    Water_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_FIRE_HEADER) ){
                    Fire_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_AIR_HEADER) ){
                    Air_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_NATURE_HEADER) ){
                    Nature_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_METAL_HEADER) ){
                    Metal_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_VITALITY_HEADER) ){
                    Vitality_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_DECAY_HEADER) ){
                    Decay_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_ARCANE_HEADER) ){
                    Arcane_Value = float.Parse(LineBits[1].Trim());
                }
                else if (LineBits[0].Equals(Constants.ITEM_DIVINE_HEADER) ){
                    Divine_Value = float.Parse(LineBits[1].Trim());
                } else if (LineBits[0].Equals(Constants.ITEM_INFERNAL_HEADER)) { 
                    Infernal_Value = float.Parse(LineBits[1].Trim());
                }
            }
        }

        public Item()
        {
        }

        public void saveFile()
        {
            List<string> writeLines = new List<string>();
            writeLines.Add(Constants.ITEM_RANK_HEADER + Constants.FILE_HEADER_SEPARATOR + Rank);
            writeLines.Add(Constants.ITEM_KITS_HEADER + Constants.FILE_HEADER_SEPARATOR + Kits.Trim());
            writeLines.Add(Constants.ITEM_BASE_HEADER + Constants.FILE_HEADER_SEPARATOR + Base.Trim());
            foreach (string addative in Addatives)
            {
                writeLines.Add(Constants.ITEM_ADDATIVE_HEADER + Constants.FILE_HEADER_SEPARATOR + addative.Trim());
            }
            foreach (string attribute in Attributes)
            {
                writeLines.Add(Constants.ITEM_ATTRIBUTES_HEADER + Constants.FILE_HEADER_SEPARATOR + attribute.Trim());
            }
            writeLines.Add(Constants.ITEM_VALUE_HEADER + Constants.FILE_HEADER_SEPARATOR + Value);
            writeLines.Add(Constants.ITEM_EFFECT_HEADER + Constants.FILE_HEADER_SEPARATOR + Effect);
            writeLines.Add(Constants.ITEM_WATER_HEADER + Constants.FILE_HEADER_SEPARATOR + Water_Value);
            writeLines.Add(Constants.ITEM_FIRE_HEADER + Constants.FILE_HEADER_SEPARATOR + Fire_Value);
            writeLines.Add(Constants.ITEM_AIR_HEADER + Constants.FILE_HEADER_SEPARATOR + Air_Value);
            writeLines.Add(Constants.ITEM_NATURE_HEADER + Constants.FILE_HEADER_SEPARATOR + Nature_Value);
            writeLines.Add(Constants.ITEM_METAL_HEADER + Constants.FILE_HEADER_SEPARATOR + Metal_Value);
            writeLines.Add(Constants.ITEM_VITALITY_HEADER + Constants.FILE_HEADER_SEPARATOR + Vitality_Value);
            writeLines.Add(Constants.ITEM_DECAY_HEADER + Constants.FILE_HEADER_SEPARATOR + Decay_Value);
            writeLines.Add(Constants.ITEM_ARCANE_HEADER + Constants.FILE_HEADER_SEPARATOR + Arcane_Value);
            writeLines.Add(Constants.ITEM_DIVINE_HEADER + Constants.FILE_HEADER_SEPARATOR + Divine_Value);
            writeLines.Add(Constants.ITEM_INFERNAL_HEADER + Constants.FILE_HEADER_SEPARATOR + Infernal_Value);
            Program.TOOLS.saveFile(Constants.DIR_ITEM_FILES + Name + ".txt", writeLines);
        }
    }
}

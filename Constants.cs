using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Potion_Crafting_Tool
{
    class Constants
    {
        public static string DIR_ITEM_FILES = System.AppDomain.CurrentDomain.BaseDirectory + "Items\\";

        public static string FILE_HEADER_SEPARATOR = "<H>";
        public static string FILE_ITEM_SEPARATOR = "<~!~>";

        public static string STATIC_NONE = "[NONE]";
        public static string STATIC_STATE_EDIT = "EDIT";
        public static string STATIC_STATE_CRAFT = "CRAFT";

        public static string ITEM_RANK_HEADER = "<Rank>";
        public static string ITEM_KITS_HEADER = "<Kits>";
        public static string ITEM_BASE_HEADER = "<Base>";
        public static string ITEM_ADDATIVE_HEADER = "<Addative>";
        public static string ITEM_ATTRIBUTES_HEADER = "<Attributes>";
        public static string ITEM_VALUE_HEADER = "<Value>";
        public static string ITEM_EFFECT_HEADER = "<Effect>";
        public static string ITEM_WATER_HEADER = "<Water>";
        public static string ITEM_FIRE_HEADER = "<Fire>";
        public static string ITEM_AIR_HEADER = "<Air>";
        public static string ITEM_NATURE_HEADER = "<Nature>";
        public static string ITEM_METAL_HEADER = "<Metal>";
        public static string ITEM_VITALITY_HEADER = "<Vitality>";
        public static string ITEM_DECAY_HEADER = "<Decay>";
        public static string ITEM_ARCANE_HEADER = "<Arcane>";
        public static string ITEM_DIVINE_HEADER = "<Divine>";
        public static string ITEM_INFERNAL_HEADER = "<Infernal>";
        public static string ITEM_BASE_ATTRIBUTE = "BASE";

        public static float GP_PER_LBS_WATER = 50f;
        public static float GP_PER_LBS_FIRE = 50f;
        public static float GP_PER_LBS_AIR = 50f;
        public static float GP_PER_LBS_NATURE = 50f;
        public static float GP_PER_LBS_METAL = 100f;
        public static float GP_PER_LBS_VITALITY = 100f;
        public static float GP_PER_LBS_DECAY = 100f;
        public static float GP_PER_LBS_ARCANE = 150f;
        public static float GP_PER_LBS_DIVINE = 200f;
        public static float GP_PER_LBS_INFERNAL = 200f;

    }
}

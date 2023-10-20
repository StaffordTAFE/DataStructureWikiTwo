using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WikiFormTwo
{
    //6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
    //Use private properties for the fields which must be of type “string”.
    //The class file must have separate setters and getters, add an appropriate IComparable for the Name attribute.
    //Save the class as “Information.cs”.

    [Serializable]
    internal class Information : IComparable<Information>
    {
        //
        // Parameters
        //
        //Use private properties for the fields which must be of type “string”.

        private string name = "~";
        private string category = "~";
        private string structure = "~";
        private string definition = "~";

        //
        // Constructor
        //

        /*public Record(string name, string category, bool isLinear, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = isLinear;
            this.definition = definition;
        }*/


        //
        // Getters and Setters
        //
        //The class file must have separate setters and getters, add an appropriate IComparable for the Name attribute.


        //// Getters
        public string GetName()
        {
            if (name == "~")
            {
                return "";
            }
            else
            {
                return name;
            }
        }
        public string GetCategory()
        {
            if (category == "~")
            {
                return "";
            }
            else
            {
                return category;
            }
        }
        public string GetStructure()
        {
            return structure;
        }
        public string GetDefinition()
        {
            if (definition == "~")
            {
                return "";
            }
            else
            {
                return definition;
            }
        }

        //// Setters
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCategory(string category)
        {
            this.category = category;
        }
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
        public void SetDefinition(string definition)
        {
            this.definition = definition;
        }


        //
        // Methods
        //

        //// Compare
        public int CompareTo(Information other)
        {
            return name.CompareTo(other.name);
        }
    }
}

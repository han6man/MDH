using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Core
{
    //Enum With String Values In C#
    //https://weblogs.asp.net/stefansedich/enum-with-string-values-in-c
    //First I created the new custom attribute class, the source is below:
    /// <summary>
    /// This attribute is used to represent a string value
    /// for a value in an enum.
    /// </summary>
    public class StringValueAttribute : Attribute
    {

        #region Properties

        /// <summary>
        /// Holds the stringvalue for a value in an enum.
        /// </summary>
        public string StringValue { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor used to init a StringValue Attribute
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }

        #endregion
        
    }
    //Then I created a new Extension Method which I will use to get the string value for an enums value:
    /// <summary>
    /// Will get the string value for a given enums value, this will
    /// only work if you assign the StringValue attribute to
    /// the items in your enum.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    //public static string GetStringValue(this Enum value)
    //{
    //    // Get the type
    //    Type type = value.GetType();

    //    // Get fieldinfo for this type
    //    FieldInfo fieldInfo = type.GetField(value.ToString());

    //    // Get the stringvalue attributes
    //    StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
    //        typeof(StringValueAttribute), false) as StringValueAttribute[];

    //    // Return the first if there was a match.
    //    return attribs.Length > 0 ? attribs[0].StringValue : null;
    //}

    class enums
    {
        //So now create your enum and add the StringValue attributes to your values:
        public enum Test : int
        {
            [StringValue("a")]
            Foo = 1,
            [StringValue("b")]
            Something = 2
        }
        
        //Now you are ready to go, to get the string value for a value in the enum you can do so like this now:
        //Test t = Test.Foo;
        //string val = t.GetStringValue();
        ////- or even -
        //string val = Test.Foo.GetStringValue();
    }
}

//https://stackoverflow.com/questions/8588384/how-to-define-an-enum-with-string-value
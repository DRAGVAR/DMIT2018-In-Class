using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestraunt.Entities.DTOs
{
    // A delegate is a reference to a method
    public delegate Grade GradeConverter(int percent);

    #region Grade
    public enum Grade
    {
        A, B, C, D, E, F
    }
    #endregion

    #region Country
    public enum Country
    {
        Canada, SouthKorea
    }
    #endregion

    #region KoreanSchool
    public class KoreanSchool
    {
        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent >= 95)
                result = Grade.A;
            else if (percent >= 85)
                result = Grade.B;
            else
                result = Grade.F;
            return result;
        }
    }
    #endregion

    #region CanadianSchool
    public class CanadianSchool
    {
        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent >= 80)
                result = Grade.A;
            else if (percent >= 65)
                result = Grade.B;
            else if (percent >= 50)
                result = Grade.C;
            else
                result = Grade.F;
            return result;
        }
    }
    #endregion

    #region AdHoc
    public class AdHoc : IAdHoc // This class implements IAdHoc interface
    {
        // A class has fields, properties, and methods
        #region IsHounours1
        public bool IsHonours(GradeConverter callback)
        {
            Grade result = callback(75);
            return IsHonours(result);
        }
        #endregion

        #region ConvertToGrade
        public Grade ConvertToGrade(int percent)
        {
            Grade result;
            if (percent >= 80)
                result = Grade.A;
            else if (percent >= 70)
                result = Grade.B;
            else if (percent >= 60)
                result = Grade.C;
            else if (percent >= 50)
                result = Grade.D;
            else
                result = Grade.F;
            return result;
        }
        #endregion

        #region IsHonours2
        public bool IsHonours(Grade value)
        {
            if (value == Grade.A)
                return true;
            else
                return false;
        }
        #endregion

        #region AsText
        public string AsText(int value)
        {
            return value.ToString();
        }
        #endregion

        #region Count
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
        #endregion
    }
    #endregion

    #region IAdHoc
    public interface IAdHoc
    {
        // An interface has properties and methods
        string name;
        // Properties and methods do NOT have an implementation in an interface
        string AsText(int value);
        int Count { get; } // Properties can have a get, set, or both
    }
    #endregion
}

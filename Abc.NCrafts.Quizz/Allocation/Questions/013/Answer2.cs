﻿namespace Abc.NCrafts.Quizz.Questions._013
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var areEqual = AreEqual("NCrafts", "ncrafts");
            // end

            Logger.Log("AreEqual: {0}", areEqual);
        }

        private static bool AreEqual(string value1, string value2)
        {
            return value1.ToLowerInvariant().Equals(value2);
        }
    }
}
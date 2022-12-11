using System;

namespace GenderSensitiveCommunicationApi.ErrorHandling
{
    [Serializable]
    public class LanguageViolationException : Exception
    {
        public LanguageViolationException(string message) : base(message) { }

    }
}

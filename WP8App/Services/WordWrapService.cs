﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPAppStudio.Services.Interfaces;

namespace WPAppStudio.Services
{
    public class WordWrapService
    {
        private readonly ITextMeasurementService _textMeasurementService;

        public WordWrapService(ITextMeasurementService textMeasurementService)
        {
            _textMeasurementService = textMeasurementService;
        }

        public string GetWords(string text, int wordCount)
        {

            StringBuilder result = new StringBuilder();

            for (int word = 0; word < wordCount; word++)
            {
                int space = text.IndexOf(' ', 1);
                //return text.Substring(0, space);
                if (space == -1)
                {
                    result.Append(text);
                    return result.ToString();
                }
                result.Append(text.Substring(0, space));
                text = text.Substring(space);
                
            }

            return result.ToString();
        }

        public string GetLine(string text, int lineLength)
        {
            throw new NotImplementedException();
        }
    }
}

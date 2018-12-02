﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Quiz_App
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Private Fields
        private string _questionOnScreen = "14 + 28 = ?";
        private string _answer1 = "36";
        private string _answer2 = "45";
        private string _answer3 = "43";
        private string _answer4 = "42";
        #endregion
        #region Constructor
        public ViewModel()
        {
            ButtonCommands = new ButtonCommands(this); 
        }
        #endregion
        #region Public Properties
        public string QuestionOnScreen
        {
            get => this._questionOnScreen;
            set
            {
                if(this._questionOnScreen != value)
                {
                    this._questionOnScreen = value;
                    OnPropertyChanged("QuestionOnScreen");
                }
            }
        }

        public string Answer1
        {
            get => this._answer1;
            set
            {
                if(this._answer1 != value)
                {
                    this._answer1 = value;
                    OnPropertyChanged("Answer1");
                }
            
}
        }

        public string Answer2
        {
            get => this._answer2;
            set
            {
                if(this._answer2 != value)
                {
                    this._answer2 = value;
                    OnPropertyChanged("Answer2");
                }
            }
        }

        public string Answer3
        {
            get => this._answer3;
            set
            {
                if(this._answer3 != value)
                {
                    this._answer3 = value;
                    OnPropertyChanged("Answer3");
                }
            }
        }

        public string Answer4
        {
            get => this._answer4;
            set
            {
                if(this._answer4 != value)
                {
                    this._answer4 = value;
                    OnPropertyChanged("Answer4");
                }
            }
        }

        public ButtonCommands ButtonCommands { get; }
        #endregion
        #region Questions Initialization and Array
        public static Question Q1 = new Question("13 + 2 = ?", "13","12","15","16","15");
        public static Question Q2 = new Question("12 + 7 = ?", "13","20","15","19","19");
        public static Question Q3 = new Question("33 - 15 = ?", "21","18","19","16","18");
        public static Question Q4 = new Question("23 + 21 = ?", "44","42","45","46","44");
        public static Question Q5 = new Question("10 + 12 = ?", "23","20","22","21","22");
        public static Question Q6 = new Question("45 - 12 = ?", "35","31","32","33","33");
        public static Question Q7 = new Question("9 + 3 = ?", "13","12","15","14","12");
        public static Question Q8 = new Question("23 - 17 = ?", "3","2","5","6","6");
        public static Question Q9 = new Question("12 - 9 = ?", "3","2","5","6","3");
        public static Question Q10 = new Question("34 + 27 = ?", "63","62","65","61","61");

        public static List<Question> Questions = new List<Question>
        {
            Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10
        };
        
        #endregion
        #region INotifyPropertyChanged Definition
        /// <summary>
        /// if property is changed, invoke new property changed event
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}

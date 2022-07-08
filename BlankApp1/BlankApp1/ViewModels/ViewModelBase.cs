using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.ViewModels
{
    
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        private int firstnumber, secondnumber;
       
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
     
    
    public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
            checkbtn =  new DelegateCommand(onButtonCheckClick);
            retrybtn = new DelegateCommand(onButtonRetryClick);
            addbtn  = new DelegateCommand(onButtonChangeAddClick);
            reducebtn = new DelegateCommand(onButtonChangeReduceClick);
            multiplicationbtn = new DelegateCommand(onButtonChangeMultiplicationClick);
            divisionbtn = new DelegateCommand(onButtonChangeDivisionClick);
            Random generator = new Random();
            firstnumber = generator.Next(1, 1000);
            secondnumber = generator.Next(1, 1000);
            FirstName = firstnumber.ToString();
            SecondName = secondnumber.ToString();
            Symbol = "+";
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
        public string MyEntry { get; set; }
        public string MyLabel { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Symbol { get; set; }


        public DelegateCommand checkbtn { get; set; }
        public DelegateCommand retrybtn { get; set; }
        public DelegateCommand addbtn { get; set; }
        public DelegateCommand reducebtn { get; set; }
        public DelegateCommand multiplicationbtn { get; set; }
        public DelegateCommand divisionbtn { get; set; }



        public void onButtonCheckClick()
        {
            switch (Symbol)
            {
                case "+":
                    if (firstnumber + secondnumber == Int32.Parse(MyEntry))
                    {
                        MyLabel = "答案正確";
                    }
                    else
                    {
                        MyLabel = "答案錯誤";
                    }
                    break;
                case "-":
                    if (firstnumber - secondnumber == Int32.Parse(MyEntry))
                    {
                        MyLabel = "答案正確";
                    }
                    else
                    {
                        MyLabel = "答案錯誤";
                    }
                    break;
                case "*":
                    if (firstnumber * secondnumber == Int32.Parse(MyEntry))
                    {
                        MyLabel = "答案正確";
                    }
                    else
                    {
                        MyLabel = "答案錯誤";
                    }
                    break;
                case "/":
                    if (firstnumber / secondnumber == Int32.Parse(MyEntry))
                    {
                        MyLabel = "答案正確";
                    }
                    else
                    {
                        MyLabel = "答案錯誤";
                    }
                    break;
            }
            

           
        }
        public void onButtonRetryClick()
        {
            Random generator = new Random();
            firstnumber = generator.Next(1, 1000);
            secondnumber = generator.Next(1, 1000);
            FirstName = firstnumber.ToString();
            SecondName = secondnumber.ToString();
            MyLabel = "";
        }

        
        public void onButtonChangeAddClick()
        {
            Symbol = "+";
            MyLabel = "";
        }
        public void onButtonChangeReduceClick()
        {
            Symbol = "-";
            MyLabel = "";
        }
        public void onButtonChangeMultiplicationClick()
        {
            Symbol = "*";
            MyLabel = "";
        }
        public void onButtonChangeDivisionClick()
        {
            Symbol = "/";
            MyLabel = "";
        }

    }
}

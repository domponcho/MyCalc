using MyCalc.Core.Calculators;
using MyCalc.ViewModels.Base;
using Prism.Commands;
using System;

namespace MyCalc.ViewModels
{
    class ShellViewModel:ViewModelBase
    {
        private readonly ICalculator _calculator;
        private bool hasCalculated;
        public ShellViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string Title { get; } = "My Calculator";

        private string _expression;
        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }

        public DelegateCommand<object> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void Calculate()
        {
            Expression = _calculator.Calculate(Expression).ToString("0.#####");
            hasCalculated = true;
        }

        private void Clear()
        {
            Expression = string.Empty;
        }

        private void AddNumber(object buttonValue)
        {
            if (hasCalculated)
            {
                Clear();
                hasCalculated = false;
            }
            Expression += buttonValue;
        }
    }
}

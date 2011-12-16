﻿namespace AjLang.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AjLang.Expressions;

    public class SetVariableCommand
    {
        private string name;
        private IExpression expression;

        public SetVariableCommand(string name, IExpression expression)
        {
            this.name = name;
            this.expression = expression;
        }

        public void Execute(Context context)
        {
            object value = this.expression.Evaluate(context);
            context.SetValue(this.name, value);
        }
    }
}
﻿namespace AjLang.Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AjLang.Language;

    public class NameExpression : IExpression
    {
        private string name;

        public NameExpression(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public object Evaluate(Context context)
        {
            return context.GetValue(this.name);
        }
    }
}


﻿namespace AjLang.Expressions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConstantExpression
    {
        private object value;

        public ConstantExpression(object value)
        {
            this.value = value;
        }

        public object Evaluate(Environment environment)
        {
            return this.value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Parser
    {
    }

    class ExprNode
    {
        char c;
        ExprNode operand1;
        ExprNode operand2;

        ExprNode(char num)
        {
            c = num;
            operand1 = operand2 = null;
        }

        ExprNode(char op, ExprNode e1, ExprNode e2)
        {
            c = op;
            operand1 = e1;
            operand2 = e2;
        }

        ExprNode parse(string input)
        {
            string[] operatorStack = new string[50];
            string[] exprStack = new string[50];


            char c;
             while (c = input.getNextChar())
            {
                if (c == '(')
                    operatorStack.push(c);

                else if (c.isDigit())
                    exprStack.push(ExprNode(c));

                else if (c.isOperator())
                {
                    while (operatorStack.top().precedence >= c.precedence)
                    { 
                         operator = operatorStack.pop();

                        e2 = exprStack.pop();
                        e1 = exprStack.pop();
                        exprStack.push(ExprNode(operator, e1, e2));
                    }

                    operatorStack.push(c);
                }

                else if (c == ')')
                {
                    while (operatorStack.top() != '(')
                    { 
                        op = operatorStack.pop();
                        e2 = exprStack.pop();
                        e1 = exprStack.pop();
                    }
                    exprStack.push(ExprNode(operator, e1, e2));
                }

            operatorStack.pop()

        else
                {
                    error();
                    return null;
                }
                return exprStack.pop();
    }
}
   



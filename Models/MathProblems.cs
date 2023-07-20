namespace ShadowWizardMath.Models
{
    public class MathProblems
    {
        public int GenerateOperand()
        {
            // Generate a random number between 1 and 10
            Random random = new Random();
            return random.Next(1, 11);
        }

        public char GenerateOperator()
        {
            // Generate a random operator: '+' for addition, '-' for subtraction
            Random random = new Random();
            char[] operators = { '+', '-' };
            return operators[random.Next(0, 2)];
        }

        public int CalculateAnswer(int operand1, char @operator, int operand2)
        {
            // Calculate the answer based on the operator
            switch (@operator)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        public void GenerateMathProblem(out int operand1, out int operand2, out string operatorString, out int correctAnswer)
        {
            operand1 = GenerateOperand();
            operand2 = GenerateOperand();
            char @operator = GenerateOperator();
            operatorString = @operator.ToString();
            correctAnswer = CalculateAnswer(operand1, @operator, operand2);
        }

        private static Random random = new Random();

        public List<int> Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

    }

}

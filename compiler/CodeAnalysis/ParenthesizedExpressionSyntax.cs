﻿namespace compiler.CodeAnalysis
{
    sealed class ParenthesizedExpressionSyntax : ExpressionSyntax
    {
        public ParenthesizedExpressionSyntax(SyntaxToken openParenthesisToken, ExpressionSyntax expression, SyntaxToken closedParenthesisToken)
        {
            OpenParenthesisToken = openParenthesisToken;
            Expression = expression;
            ClosedParenthesisToken = closedParenthesisToken;
        }
        public override SyntaxKind Kind => SyntaxKind.ParenthesizedExpression;

        public SyntaxToken OpenParenthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken ClosedParenthesisToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return OpenParenthesisToken;
            yield return ClosedParenthesisToken;
            yield return Expression;
        }
    }
}

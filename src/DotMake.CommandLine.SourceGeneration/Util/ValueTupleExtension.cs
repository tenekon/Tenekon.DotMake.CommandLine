namespace DotMake.CommandLine.SourceGeneration.Util;

public static class ValueTupleExtension
{
    public static (TLeft Left, TRight Right)? CreateNullable<TLeft, TRight>(TLeft left, TRight right) => (left, right);

    public static NullTupleBuilderWithLeft<TLeft> NullWithLeft<TLeft>(TLeft? leftHint = default) => new();

    public readonly struct NullTupleBuilderWithLeft<TLeft>
    {
        public (TLeft Left, TRight Right)? WithRight<TRight>(TRight? rightHint = default)
        {
            return null;
        }
    }
}

namespace dotless.Core
{
    public static class Less
    {
        public static string Parse(string less)
        {
            ILessEngine engine = new LessEngine();
            return engine.TransformToCss(less, null);
        }
    }
}

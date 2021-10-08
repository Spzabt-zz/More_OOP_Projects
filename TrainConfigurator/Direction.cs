namespace TrainConfigurator
{
    public class Direction
    {
        public string StartPosition { get; private set; }
        public string EndPosition { get; private set; }

        public Direction(string startPosition,string endPosition)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
        }

        public override string ToString()
        {
            return $"{StartPosition}-{EndPosition}";
        }
    }
}
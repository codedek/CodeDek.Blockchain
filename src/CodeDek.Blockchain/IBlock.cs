namespace CodeDek.Blockchain
{
    public interface IBlock
    {
        ulong Index { get; }
        ulong Nonce { get; }
        string Data { get; }
        string Hash { get; }
        string PreviousHash { get; }
        string Timestamp { get; }
        string CalculateHash();
    }
}
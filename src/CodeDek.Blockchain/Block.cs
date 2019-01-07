using System;
using System.Security.Cryptography;
using System.Text;

namespace CodeDek.Blockchain
{
    public sealed class Block : IBlock
    {
        public ulong Index { get; }
        public ulong Nonce { get; }
        public string Data { get; }
        public string Hash { get; }
        public string PreviousHash { get; }
        public string Timestamp { get; }

        public Block(ulong index, string previousHash, string data)
        {
            Index = index;
            PreviousHash = previousHash;
            Data = data;
            Timestamp = DateTime.Now.ToLongTimeString();

            var tmpHash = "";

            while (!tmpHash.StartsWith("00"))
            {
                Nonce++;
                tmpHash = CalculateHash();
            }

            Hash = tmpHash;
        }

        public string CalculateHash()
        {
            byte[] bytes = Encoding.Unicode.GetBytes(Index + Nonce + Timestamp + PreviousHash + Data);
            byte[] hash256 = SHA256.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hash256);
        }

        public override string ToString()
        {
            return $"Index: {Index}\nNonce: {Nonce}\nPreviousHash: {PreviousHash}\nHash: {Hash}\nData: {Data}";
        }
    }
}
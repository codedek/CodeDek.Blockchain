using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CodeDek.Blockchain
{
    public sealed class Blockchain
    {
        private readonly IList<IBlock> _blocks;

        public IReadOnlyList<IBlock> Chain { get; }

        public Blockchain()
        {
            _blocks = new List<IBlock>
            {
                new Block(1, null, "Genesis Block starting fund: $100_000.000_000 ")
            };
            Chain = new ReadOnlyCollection<IBlock>(_blocks);
        }

        public IBlock GetLatestBlock()
        {
            return _blocks[_blocks.Count - 1];
        }

        public void AddBlock(IBlock block)
        {
            _blocks.Add(block);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var val in _blocks)
            {
                sb.AppendLine(val.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

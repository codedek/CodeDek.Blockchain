using Xunit;

namespace CodeDek.Blockchain.Tests
{
    public class BlockchainTests
    {
        [Fact]
        public void Blockchain_NewInstance_ReturnsChainContainingSingleGenesisBlock()
        {
            var bc = new Blockchain();
            Assert.Single(bc.Chain);
        }
    }
}

# CodeDek.Blockchain
This is a pet project created to learn Blockchain technology.

## Progress so far..
```csharp
var chain = new Blockchain();
chain.AddBlock(new Block(chain.GetLatestBlock().Index + 1, chain.GetLatestBlock().Hash, "Jon joined network: Users: 2 Jon injected $100"));
chain.AddBlock(new Block(chain.GetLatestBlock().Index + 1, chain.GetLatestBlock().Hash, "Phil joined network: Users: 3 Jon transfered to Phil $50"));
chain.AddBlock(new Block(chain.GetLatestBlock().Index + 1, chain.GetLatestBlock().Hash, "Jane joined network: Users: 4 Jane injected $10_000"));
chain.AddBlock(new Block(chain.GetLatestBlock().Index + 1, chain.GetLatestBlock().Hash, "Greg joined network: Users: 5"));

chain.ToString()
/*
  Index: 1
  Nonce: 10645
  PreviousHash: 
  Hash: 00UdGIDjNor1UrONHfFuqtY4pQ0ccrAhDjEZh6YT+9Q=
  Data: Genesis Block starting fund: $100_000.000_000 
  Index: 2
  Nonce: 1486
  PreviousHash: 00UdGIDjNor1UrONHfFuqtY4pQ0ccrAhDjEZh6YT+9Q=
  Hash: 00tTmF2EAXTJBG4b1nZqLJtLT0exhZUOs/RrPyBOZTI=
  Data: Jon joined network: Users: 2 Jon injected $100
  Index: 3
  Nonce: 2350
  PreviousHash: 00tTmF2EAXTJBG4b1nZqLJtLT0exhZUOs/RrPyBOZTI=
  Hash: 00VEdjCLTojGYZ/2UcEK6IjfmymCDhOGRzA+qZaqaVs=
  Data: Phil joined network: Users: 3 Jon transfered to Phil $50
  Index: 4
  Nonce: 2153
  PreviousHash: 00VEdjCLTojGYZ/2UcEK6IjfmymCDhOGRzA+qZaqaVs=
  Hash: 00tv4BO3nTR6er86vtdhnNQjv7q/nW2gZ81WN6qBBuI=
  Data: Jane joined network: Users: 4 Jane injected $10_000
  Index: 5
  Nonce: 7624
  PreviousHash: 00tv4BO3nTR6er86vtdhnNQjv7q/nW2gZ81WN6qBBuI=
  Hash: 00HMB8aUZRp9fQkk1FCdM3OAUBuJgVZ4Ztz8mYKGE6M=
  Data: Greg joined network: Users: 5
*/

```

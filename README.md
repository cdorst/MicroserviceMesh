# MicroserviceMesh

Use YAML to compose a SQL Server relational data model and generate .NET Core atomic microservices.

Microservices (one for each entity & operation-type) form network mesh over shared relational database.

## Elements

Each `Element` forms a code concept, entity, SQL table, Azure Table, Pay-per-view & data-ownership smart contract, etc.

Each `Element` has one or more of the following:
  - !TODO Write microservice
  - !TODO Read microservice
  - !TODO Delete microservice
  - !TODO Permissions microservices

`Element` APIs have one microservice per operation

### Element Kinds

| Kind               | Sample Implementation Story     |
| ------------------:| -------------------------------:|
| Datum              | "Experienced events             |
| DatumLabel         | are labeled,                    |
| Hierarchy          | then meta-classified            |
| HierarchyAttribute | into diagnostic-labeling mesh." |

### Stacks of Layered Blocks

#### Layers

Each `Layer` of Elements extends the `DbContext` base.

#### Blocks

Each `Block` compartmentalizes groups of Layers.

Microservice mesh solutions are generated for blocks or stacks of blocks of layered data-element declarations.

### Trees of Branched Stacks

New-growth `Branch` solutions extend `Block`-stack microservice-mesh `Trunk` solutions.

Base service-fabric mesh API is re-used by up-stream mesh application-trees.

## Features

Code generated for each element:
  - !TODO EntityFramework entity
  - !TODO EntityFramework DbContext
  - !TODO ASP.NET Core write-record microservice
  - !TODO write-record SQL Server stored procedure
  - !TODO write-record Azure Storage write
  - !TODO write-record Redis shared cache write
  - !TODO write-record Azure Table write
  - !TODO write-record Redis instance cache write
  - !TODO ASP.NET Core read-record microservice
  - !TODO read-record Azure CDN read
  - !TODO read-record Redis cache read
  - !TODO read-record Azure Table read
  - !TODO ASP.NET Core delete-record microservice
  - !TODO delete-record SQL Server stored procedure
  - !TODO delete-record Azure CDN read
  - !TODO delete-record Redis cache read
  - !TODO delete-record Azure Table read
  - !TODO delete-record permission-gate microservice
  - !TODO delete-permission read microservice
  - !TODO delete-permission write microservice
  - !TODO delete-permission delete microservice
  - !TODO write-record permission-gate microservice
  - !TODO write-permission read microservice
  - !TODO write-permission write microservice
  - !TODO write-permission delete microservice
  - !TODO read-record permission-gate microservice
  - !TODO read-permission read microservice
  - !TODO read-permission write microservice
  - !TODO read-permission delete microservice
  - !TODO client libraries .NET Standard
  - !TODO client libraries TypeScript
  - !TODO client libraries Vuex
  - !TODO client libraries Vue
  - !TODO client libraries MVC
  - !TODO client libraries Blazor
  - !TODO Solidity smart contracts
  - !TODO mesh-to-mesh shared data extensibility

## Microsoft Integration Vision 

  - Rewrite/whitelabel declarative microservice-mesh generator as .NET Mesh
  - Integrate .NET Mesh solutions => Service Fabric Mesh production & dev deployment
  - Use .NET Mesh to extend Microsoft Graph
  - Create public data cache
  - Create private/pay-per-view data vault w/ smart contracts using "Microsoft Money" tokens on Microsoft Blockchain
  - .NET developers create & extend public & private graphs by branching (and sharing the same data "trunk" as other applications)
  - Concept-reuse/consolidation of industry/government data infrastructure
  - Cosmos-scale, highly-available digital utility-grid

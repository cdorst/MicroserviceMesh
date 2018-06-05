# Microservice Mesh

Compose a SQL Server relational data model & generate .NET Core atomic microservices with YAML declarations.

Containerized microservices (one for each entity & operation-type) form HTTP-API network mesh over shared relational-data sources.

## Entities

Each `Entity` forms a code entity, SQL table, Azure Table, pay-per-view & data-ownership smart contract, etc.

`Entity` APIs have one microservice per operation

Each `Entity` has one or more of the following:
  - !TODO Write microservice
  - !TODO Read microservice
  - !TODO Delete microservice
  - !TODO Permissions microservices

### Grammar

Microservice solution **Blocks** (with **Slices** of **Rings** of **Entity** dependencies) stack and branch into meta-solution **Trees** with shared-resource trunks.

#### Entity Kinds

**Kind** types differentiate **Entity** types by story role: 

| Kind                 | Story                            |
| --------------------:| ---------------------------------:|
| `Datum`              | "Observed data                   |
| `DatumLabel`         | is labeled,                      |
| `Hierarchy`          | then meta-classified             |
| `HierarchyAttribute` | and hyperlinked with metadata." |

`DatumLabel` entities label `Datum`-entity data-values.

`Hierarchy` entities represent unique relationship-conceptualizations of labeled data (and other hierarchies).

`HierarchyAttribute` entities attach factual trivia to `Hierarchy`-concept entities. 

#### Rings

Each **Ring** contains one or **Entity** of the same **Kind**.

Within each **Block** **Slice**, **Entity** types are differentiated into overlapping (dependent) **Rings**.

#### Slices

Each **Slice** contains one or more **Entity** **Ring**.

Each **Slice** of Entities extends the `DbContext` base; every **Ring** sharing the same derived **Slice** `DbContext` class.

#### Blocks

Each **Block** contains one or more **Slice**.

Microservice mesh solutions are generated for blocks or stacks of blocks of layered data-entity declarations.

### Trees of Branched Stacks

New-growth `Branch` solutions extend `Block`-stack microservice-mesh `Trunk` solutions.

Base service-fabric mesh API is re-used by up-stream mesh application-trees.

#### Integration Contracts

Service-fabric mesh application APIs published well defined smart contract & integrations broker application.

Customers purchase smart-contract from integrations broker that integrates their API `Block` mesh-as-a-service solution onto your solution `Stack`.

## Factory

`/Factory` operations streamline production of `Solution` artifacts.

### Generator

Use `Generator` within `/Factory` to generate `Solution` artifacts from `/Factory/Schematics` work-specification declarations.

### Schematicss

`/Factory/Schematics` `Declaration` project containers `Layers` of work-specification declarations.

#### Declaration.Generator

Use `Declaration.Generator` within `/Factory/Schematics` to generate `Declaration` artifacts from YAML specifications under the project's `/Declaration` directory.

Run `.\generate-declaration.ps1` or `./generate-declaration.sh` at the repository root to craft the `/Factory/Schematics/Declaration/Layers`-directory artifacts using the `Declaration.Generator`.

### Workbench

`/Factory` meta-work artifacts (e.g. `Benchmarks`, `Fixtures`, `Jigs`, & `Measurements`) are located under `/Factory/Workbench`.

#### Benchmarks

`Experiments` collect evidence used when considering which alternative `Benchmark` code-lines to use when crafting the Solution.

#### Jigs

Custom-manufactured `Jigs` facilitate repeated code cuts given multiple same-shaped inputs.

Run `.\jigs.ps1` or `./jigs.sh` at the repository root to remill code cut using `Jigs`.

#### Measurements

`Measurements` are repeatable observations used to exact specifications on new code & determine correct contribution needed for existing code.

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

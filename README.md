[![FINOS - Incubating](https://cdn.jsdelivr.net/gh/finos/contrib-toolbox@master/images/badge-incubating.svg)](https://community.finos.org/docs/governance/Software-Projects/stages/incubating)

# Backplane

Desktop Agent bridge aka 'Backplane' is a component which allows different desktop agents to connect and communicate through websockets.

Where FDC3 Desktop Agent API addresses interoperability between apps running within the context of a single Desktop Agent (DA), facilitating cross-application workflows, FDC3 Desktop Agent Backplane addresses the interconnection of Desktop Agents (DAs) such that apps running under different Desktop Agents can also interoperate, allowing workflows to span multiple Desktop Agents

## Why Backplane?

Imagine a business Workflow that involves applications which are not running under same desktop agent, how can we make applications interoperate across different desktop agents? This is where DA Backplane comes into picture.

The power and benefits of FDC3 based interoperability can be harnessed to full potential only if it is not just limited to boundaries of desktop agent but across desktop.

### ✔️ Workflows can be spanned to multiple desktop agents (DAs) on desktop.

### ✔️ Workflows can be spanned across multiple machines, provided they are operated by same user.

\*Discovery interface implementation is not in in scope of this project. It has to be implemented by consumer based on own approach of registration and discovery of member backplanes)

## Installation

Coming soon!

## Usage example

### Backplane

A desktop service which act as a message bus between multiple desktop agents for sending/receiving FDC3 compliant data.
See more here: [backplane-client-js](docs\backplane-service.md).

Client libraries provide API to connect and communicate with backplane.

### Backplane client Web

Javascript client which allows web based desktop agents to connect and communicate with backplane through API.

See more here: [backplane-client-js](docs\backplane-client-js.md).

### Backplane client .NET

For desktop agent build in .NET, this client library exposed API to connect and communicate with backplane.

see more here: [backplane-client-net](docs\backplane-client-net.md)

## Development setup

IDE

1.  Visual Studio 2022.
2.  VS code.

Build
Backplane and .NET Client

1. Open 'Finos.Fdc3.Backplane.sln' at root in visual studio.
2. Build Solution.
3. Nuget package is created in 'output' folder at root.
4. Publish the Finos.Fdc3.Backplane project as self contained.
5. Launch backplane by running the exe in publish folder.

JS Client

1. Open folder '\src\Finos.Fdc3.Backplane.Client.JS' in vs code.
2. Run command 'yarn prepare' in new terminal.
3. npm package should be created in 'output' folder at root.

## Roadmap

1. Provide/enhance developer documentation.
2. Evolve the implementation to meet the emerging FDC3 specifications for Desktop Agent Bridging [!Draft](https://github.com/finos/FDC3/blob/544-Desktop-Agent-Bridging-Proposal/docs/api-bridging/spec.md).
3. Deprecate interim DA to Bridge integrations as vendor support for standard enables direct bridge connections
4. Provide examples for multi host discovery implementations in line with concrete use cases.
5. Update system topology to include use of standalone Desktop Agent in line with emerging standard.

## Contributing

For any questions, bugs or feature requests please open an [issue](https://github.com/finos/backplane/issues)
For anything else please send an email to {project mailing list}.

To submit a contribution:

1. Fork it (<https://github.com/finos/backplane/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Read our [contribution guidelines](.github/CONTRIBUTING.md) and [Community Code of Conduct](https://www.finos.org/code-of-conduct)
4. Commit your changes (`git commit -am 'Add some fooBar'`)
5. Push to the branch (`git push origin feature/fooBar`)
6. Create a new Pull Request

_NOTE:_ Commits and pull requests to FINOS repositories will only be accepted from those contributors with an active, executed Individual Contributor License Agreement (ICLA) with FINOS OR who are covered under an existing and active Corporate Contribution License Agreement (CCLA) executed with FINOS. Commits from individuals not covered under an ICLA or CCLA will be flagged and blocked by the FINOS Clabot tool (or [EasyCLA](https://community.finos.org/docs/governance/Software-Projects/easycla)). Please note that some CCLAs require individuals/employees to be explicitly named on the CCLA.

_Need an ICLA? Unsure if you are covered under an existing CCLA? Email [help@finos.org](mailto:help@finos.org)_

## License

Copyright {yyyy} {name of copyright owner}

Distributed under the [Apache License, Version 2.0](http://www.apache.org/licenses/LICENSE-2.0).

SPDX-License-Identifier: [Apache-2.0](https://spdx.org/licenses/Apache-2.0)

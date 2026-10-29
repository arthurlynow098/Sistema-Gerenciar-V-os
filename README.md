<p align="center">
  <img src="assets/banner.png" alt="Sistema de Gestão de Voos" width="100%">
</p>

<p align="center">
  Aplicação desktop em C# Windows Forms integrada ao SQL Server via DataSet tipado para cadastro e gerenciamento de aeronaves e pilotos.
</p>

<p align="center">
  <img alt="C#" src="https://img.shields.io/badge/C%23-Windows_Forms-C52E36?style=for-the-badge&logo=dotnet&logoColor=white">
  <img alt="SQL Server" src="https://img.shields.io/badge/Database-SQL_Server-11120F?style=for-the-badge&logo=microsoftsqlserver&logoColor=C52E36">
  <img alt=".NET 4.7.2" src="https://img.shields.io/badge/.NET_Framework-4.7.2-18181B?style=for-the-badge">
</p>

## Sobre o projeto

O **Sistema de Gerenciamento de Voos (WfaDS)** é uma aplicação desktop corporativa construída em **C# com Windows Forms (.NET Framework 4.7.2)** e banco de dados **SQL Server**, desenvolvida para centralizar o controle cadastral da frota de aeronaves e do quadro de pilotos de uma operação aérea.

O projeto implementa um fluxo completo de aplicação desktop clássica: tela de abertura animada (Splash), painel principal de navegação (Menu_Geren), formulários especializados (Aeronaves_gen e Pilotos_gen) e camada de persistência fortemente tipada com LP2DataSet (XSD).

## Principais recursos

| Recurso | Como funciona |
|---|---|
| Tela de Inicialização (Splash) | Formulário de carregamento inicial antes de liberar o menu principal do sistema. |
| Painel Central (Menu_Geren) | Hub de navegação que conecta o operador aos módulos de frota e tripulação. |
| Gestão de Frota (Aeronaves_gen) | Cadastro, consulta, atualização e exclusão de aeronaves vinculadas ao banco de dados. |
| Gestão de Tripulação (Pilotos_gen) | Controle completo dos registros de pilotos habilitados na operação. |
| DataSet Tipado (LP2DataSet.xsd) | Mapeamento do schema SQL Server com TableAdapters para operações seguras de leitura e escrita. |

## Tecnologias

<p>
  <img alt="C#" src="https://img.shields.io/badge/C%23-C52E36?style=flat-square&logo=dotnet&logoColor=white">
  <img alt=".NET Framework" src="https://img.shields.io/badge/.NET_Framework_4.7.2-11120F?style=flat-square&logo=dotnet&logoColor=C52E36">
  <img alt="Windows Forms" src="https://img.shields.io/badge/Windows_Forms-C52E36?style=flat-square&logo=windows&logoColor=white">
  <img alt="SQL Server" src="https://img.shields.io/badge/SQL_Server-11120F?style=flat-square&logo=microsoftsqlserver&logoColor=C52E36">
</p>

## Arquitetura

`mermaid
flowchart LR
    A[Splash.cs · Inicialização] --> B[Menu_Geren.cs · Menu Principal]
    B --> C[Aeronaves_gen.cs · Frota]
    B --> D[Pilotos_gen.cs · Tripulação]
    C --> E[LP2DataSet.xsd · TableAdapters]
    D --> E
    E --> F[(SQL Server)]
`

## Estrutura do repositório

`	ext
Sistema-Gerenciar-V-os/
├── assets/
│   ├── banner.png                  Banner principal Gestão de Voos
│   └── project-animal.png          Símbolo do albatroz
├── WfaDS/
│   ├── Splash.cs                   Tela inicial de abertura do sistema
│   ├── Menu_Geren.cs               Menu principal de navegação
│   ├── Aeronaves_gen.cs            Formulário de gerenciamento de aeronaves
│   ├── Pilotos_gen.cs              Formulário de gerenciamento de pilotos
│   ├── LP2DataSet.xsd              Schema tipado e TableAdapters do SQL Server
│   ├── App.config                  String de conexão e configurações de runtime
│   └── Program.cs                  Ponto de entrada da aplicação desktop
├── WfaDS.sln                       Solução Visual Studio
└── README.md
`

## Executando o código

1. Clone o repositório no Windows:
   `powershell
   git clone https://github.com/arthurlynow098/Sistema-Gerenciar-V-os.git
   `
2. Abra WfaDS.sln no **Visual Studio** e verifique a string de conexão do SQL Server no arquivo WfaDS/App.config.
3. Compile e inicie a aplicação pressionando **F5**.

---

<p align="center"><sub>Estudo · construção · evolução</sub><br><a href="https://github.com/arthurlynow098">Perfil</a> · <a href="https://arthurentsev.vercel.app/">Portfólio</a> · <a href="https://www.linkedin.com/in/entsevarthur/">LinkedIn</a></p>

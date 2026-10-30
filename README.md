<p align="center">
  <img src="assets/identity/banner.png" alt="Sistema-Gerenciar-V-os" width="100%">
</p>

<p align="center">Aplicação desktop para cadastro e gerenciamento de aeronaves e pilotos.</p>


<p align="center"><a href="#visão-geral">Visão geral</a> &nbsp;·&nbsp; <a href="#recursos">Recursos</a> &nbsp;·&nbsp; <a href="#como-executar">Como executar</a></p>

<p align="center"><img src="assets/identity/divider.svg" alt="" width="100%"></p>

<a id="explore-o-projeto"></a>

## Por onde começar


- **[Navegação](WfaDS/Menu_Geren.cs)** — Formulário de acesso às funcionalidades.
- **[Aeronaves](WfaDS/Aeronaves_gen.cs)** — Código do formulário de aeronaves.
- **[Pilotos](WfaDS/Pilotos_gen.cs)** — Código do formulário de pilotos.


<a id="visão-geral"></a>

## Visão geral

O projeto implementa um fluxo completo de aplicação desktop clássica: tela de abertura animada (Splash), painel principal de navegação (Menu_Geren), formulários especializados (Aeronaves_gen e Pilotos_gen) e camada de persistência fortemente tipada com LP2DataSet (XSD).

<a id="recursos"></a>

## Recursos

**Tela de Inicialização (Splash)**<br>
Formulário de carregamento inicial antes de liberar o menu principal do sistema.

**Painel Central (Menu_Geren)**<br>
Hub de navegação que conecta o operador aos módulos de frota e tripulação.

**Gestão de Frota (Aeronaves_gen)**<br>
Cadastro, consulta, atualização e exclusão de aeronaves vinculadas ao banco de dados.

**Gestão de Tripulação (Pilotos_gen)**<br>
Controle completo dos registros de pilotos habilitados na operação.

**DataSet Tipado (LP2DataSet.xsd)**<br>
Mapeamento do schema SQL Server com TableAdapters para operações seguras de leitura e escrita.

<details>
<summary>Arquitetura</summary>

```mermaid
flowchart LR
    A["Splash.cs · Inicialização"] --> B["Menu_Geren.cs · Menu Principal"]
    B --> C["Aeronaves_gen.cs · Frota"]
    B --> D["Pilotos_gen.cs · Tripulação"]
    C --> E["LP2DataSet.xsd · TableAdapters"]
    D --> E
    E --> F["(SQL Server)"]
```

</details>

<details>
<summary>Estrutura do repositório</summary>

```text
Sistema-Gerenciar-V-os/
├── assets/
│   └── identity/banner.png               Banner do projeto
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
```

</details>

<a id="como-executar"></a>

## Como executar

1. Clone o repositório no Windows:
   ```powershell
   git clone https://github.com/arthurlynow098/Sistema-Gerenciar-V-os.git
   ```
2. Abra WfaDS.sln no **Visual Studio** e verifique a string de conexão do SQL Server no arquivo WfaDS/App.config.
3. Compile e inicie a aplicação pressionando **F5**.

<p align="center"><img src="assets/identity/divider.svg" alt="" width="100%"></p>

<p align="center">
  <a href="https://github.com/arthurlynow098">GitHub</a> &nbsp;·&nbsp;
  <a href="https://arthurentsev.vercel.app/">Portfólio</a> &nbsp;·&nbsp;
  <a href="https://www.linkedin.com/in/entsevarthur/">LinkedIn</a>
</p>

<p align="center">
  <img src="assets/banner-v2.png" alt="Sistema-Gerenciar-V-os" width="100%">
</p>

<p align="center">Aplicação desktop para cadastro e gerenciamento de aeronaves e pilotos.</p>

<p align="center"><img src="assets/docs/tags.svg" alt="C# · Windows Forms · SQL Server" width="100%"></p>

<p align="center"><a href="#visão-geral">Visão geral</a> &nbsp;·&nbsp; <a href="#recursos">Recursos</a> &nbsp;·&nbsp; <a href="#como-executar">Como executar</a></p>

---

<a id="explore-o-projeto"></a>

![Explore o projeto](assets/docs/section-01.svg)

![Mapa visual dos arquivos e responsabilidades](assets/docs/map.svg)

<table width="100%">
<tr><th align="left">Área</th><th align="left">O que você encontra</th><th align="left">Acesso direto</th></tr>
<tr><td><strong>Navegação</strong></td><td>Formulário de acesso às funcionalidades.</td><td><a href="WfaDS/Menu_Geren.cs">Abrir navegação →</a></td></tr>
<tr><td><strong>Aeronaves</strong></td><td>Código do formulário de aeronaves.</td><td><a href="WfaDS/Aeronaves_gen.cs">Abrir aeronaves →</a></td></tr>
<tr><td><strong>Pilotos</strong></td><td>Código do formulário de pilotos.</td><td><a href="WfaDS/Pilotos_gen.cs">Abrir pilotos →</a></td></tr>
</table>

<a id="visão-geral"></a>

![Visão geral](assets/docs/section-02.svg)

O projeto implementa um fluxo completo de aplicação desktop clássica: tela de abertura animada (Splash), painel principal de navegação (Menu_Geren), formulários especializados (Aeronaves_gen e Pilotos_gen) e camada de persistência fortemente tipada com LP2DataSet (XSD).

<a id="recursos"></a>

![Recursos](assets/docs/section-03.svg)

| Recurso | Como funciona |
|---|---|
| Tela de Inicialização (Splash) | Formulário de carregamento inicial antes de liberar o menu principal do sistema. |
| Painel Central (Menu_Geren) | Hub de navegação que conecta o operador aos módulos de frota e tripulação. |
| Gestão de Frota (Aeronaves_gen) | Cadastro, consulta, atualização e exclusão de aeronaves vinculadas ao banco de dados. |
| Gestão de Tripulação (Pilotos_gen) | Controle completo dos registros de pilotos habilitados na operação. |
| DataSet Tipado (LP2DataSet.xsd) | Mapeamento do schema SQL Server com TableAdapters para operações seguras de leitura e escrita. |

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
│   └── banner-v2.png               Banner do projeto
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

![Como executar](assets/docs/section-04.svg)

1. Clone o repositório no Windows:
   ```powershell
   git clone https://github.com/arthurlynow098/Sistema-Gerenciar-V-os.git
   ```
2. Abra WfaDS.sln no **Visual Studio** e verifique a string de conexão do SQL Server no arquivo WfaDS/App.config.
3. Compile e inicie a aplicação pressionando **F5**.

---

<p align="center">
  <a href="https://github.com/arthurlynow098">GitHub</a> &nbsp;·&nbsp;
  <a href="https://arthurentsev.vercel.app/">Portfólio</a> &nbsp;·&nbsp;
  <a href="https://www.linkedin.com/in/entsevarthur/">LinkedIn</a>
</p>

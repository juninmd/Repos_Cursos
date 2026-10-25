# AGENTS.md - Repos Cursos

## Tech Stack
- **Subjects:** Angular, Ionic, React Native, Node.js, JavaScript, Git, HTML, CSS
- **Format:** Course materials with source code

## Project Structure
```
Curso-Angular-4/            # Angular 4 course
curso-git/                  # Git course
curso-html-aula-1..8/       # HTML course (8 lessons)
Curso-Ionic-3/              # Ionic 3 course
curso-javascript/           # JavaScript course
curso-node-js/              # Node.js course
curso-node-ts/              # Node.js + TypeScript course
curso-react-native/         # React Native course
Curso-Slack/                # Slack course
curso-web-development/      # Web development course
```

## Notes
- Collection of course repositories
- Each subdirectory is a standalone course with exercises and code

<!-- base-actions-main-policy -->
## GitHub Actions — padrão obrigatório (@main)

- Referencie as actions internas sempre pelo branch, nunca por SHA:
  - `uses: juninmd/base-actions/<action>@main`
  - `uses: juninmd/base-actions/.github/workflows/<arquivo>.yml@main`
- Não fixe `@<sha>` em `juninmd/base-actions`: a atualização é centralizada no
  `main` e passa a valer no próximo run.
- PRs cujos checks não iniciam por billing/spending limit são mesclados pelo bot central
  `juninmd/base-actions/.github/workflows/auto-merge-billing-blocked.yml`.
  Para impedir o merge automático de um PR, aplique a label `do-not-merge`.
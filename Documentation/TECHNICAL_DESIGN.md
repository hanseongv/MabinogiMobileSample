
# Technical Design

## 1. Development Environment

- Unity Version: 6000.3.20f1
- Programming Language: C#
- IDE: VS Code
- Target Platform: Mobile

## 2. Project Architecture

주요 시스템의 책임을 정의한다.

### Core
게임 초기화 및 공통 시스템 관리

### Player
플레이어 이동, 상태, 애니메이션 관리

### Field
필드 구성, 맵 이동, 충돌 및 환경 관리

### Combat
공격, 스킬, 피해 계산 및 전투 처리

### Interaction
NPC 및 오브젝트 상호작용

### UI
게임 UI 및 화면 관리

### Data
게임 데이터 및 설정 관리

## 3. Data Management

- Static Data: ScriptableObject 등을 활용
- Runtime Data: 실행 중 변경되는 데이터
- Save Data: 저장이 필요한 데이터

## 4. Scene Management

초기 씬 구성 및 씬 전환 방식 정의

## 5. Asset Management

- Project Assets: Assets/_Project
- Third Party Assets: 별도 폴더로 관리

## 6. Coding Rules

- Class / Method: PascalCase
- Private Field: _camelCase
- Local Variable: camelCase
- Interface: IPascalCase
- Prefer [SerializeField] private fields
- Follow Single Responsibility Principle

## 7. Git Workflow

- main: 안정적인 개발 상태
- feature/*: 신규 기능
- fix/*: 버그 수정
- refactor/*: 코드 구조 개선
- docs/*: 문서 수정

Commit Format:

type(scope): description

Examples:
feat(player): add player movement
fix(field): correct boundary collision
refactor(combat): separate damage calculation
docs(readme): update project overview

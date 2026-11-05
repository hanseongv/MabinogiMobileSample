# Game Design Document

## 1. Project Overview

### 1.1 Project Name
Mabinogi Mobile Sample

### 1.2 Project Purpose
마비노기 모바일의 일부 게임 시스템을
분석하고 Unity로 구현하는 학습 프로젝트.

원작의 게임 플레이 방식과 연출을 참고하여 튜토리얼 연출, 캐릭터 조작, 필드 탐험, 오브젝트 상호작용, 몬스터 전투 시스템 등을 구현하는 것을 목표로 한다.

### 1.3 Target Platform
Mobile

### 1.4 Game Genre
MMORPG
3D 액션 RPG
필드 탐험 및 실시간 전투

## 2. Core Gameplay

게임의 핵심 플레이 흐름은 
튜토리얼 진행 → 필드 탐험 → 오브젝트 상호작용 → 몬스터 전투 → 목표 달성으로 구성된다.

플레이어는 캐릭터를 직접 조작하여 필드를 이동하고, 주변 오브젝트 및 NPC와 상호작용하며 게임의 기본적인 시스템을 경험한다.

몬스터와 조우할 경우 일반 공격과 스킬을 사용하여 전투를 진행하며, 전투 상황에 따라 캐릭터의 이동 및 카메라 시점을 조작할 수 있다.

주요 플레이 흐름은 다음과 같다.
1. 게임 시작 및 튜토리얼 연출 재생
2. 튜토리얼 안내에 따라 캐릭터 기본 조작 학습
3. 필드 이동 및 카메라 조작
4. NPC 및 주변 오브젝트와 상호작용
5. 몬스터와 조우 및 전투 진행
6. 일반 공격 및 스킬을 활용한 몬스터 처치
7. 목표 달성 및 다음 진행 단계로 이동

## 3. Reference Analysis

참고할 원작의 시스템을 분석한다.

- Character Control
- Field Exploration
- Interaction
- Combat
- Character Growth

## 4. Main Features

구분	구현 기능	주요 내용
Tutorial	튜토리얼 연출	캐릭터 등장, 상황 연출, 카메라 연출
Tutorial	튜토리얼 안내	조작 안내 및 진행 단계별 이벤트

Character	캐릭터 이동	이동, 회전, 애니메이션

Camera	카메라 제어	추적, 회전, 줌, 충돌 처리

Interaction	오브젝트 상호작용, UI, 상호작용 이벤트

Combat	일반 공격	공격 입력 및 공격 판정
Combat	스킬 시스템	스킬 입력, 애니메이션, 이펙트
Combat	몬스터 공격 
Combat	전투 처리	데미지, 피격, 사망 처리

UI	게임 플레이 UI	체력, 스킬, 상호작용 UI

## 5. Game Flow

Game Start
Tutorial Sequence
Character Control
Field Exploration
Combat
Stage Clear

## 6. UI / UX

6.1 Main UI
- 플레이어 체력 UI
- 플레이어 닉네임
- 스킬 아이콘 및 스킬 사용 버튼
- 상호작용 안내 UI
- 퀘스트 및 튜토리얼 진행 안내
- 몬스터 이름
- 몬스터 체력 UI
- 전투 정보 UI
- 아이템 입수 정보 UI

## 7. Future Expansion

초기 개발 범위에는 포함하지 않지만, 프로젝트의 완성도 및 확장성을 고려하여 향후 추가할 수 있는 기능을 정의한다.
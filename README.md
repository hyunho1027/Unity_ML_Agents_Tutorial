# Unity_ML_Agents_Guide 

## 가이드 설명
- Unity ML Agents의 기본적인 사용법을 알아 봅니다.
- Unity ML Agents의 예제인 RollerBall을 직접 구현해봅니다.
- - -

- RollerBall

![Alt text](/unity_ml_agents_guide/sub/mb.gif)
- - -

## 진행 환경
- Unity 2018.1.6f1 Personal
- VisualStudio 2015 
- Tensorflow==1.5.0 
- - -

## 1. Unity를 설치합니다.

### Personal 무료 버전을 설치합니다.

unity 설치 url : https://store.unity.com/kr

![Alt text](/unity_ml_agents_guide/1.unity_download/unity_download.png)
- - -

## 2. Unity ml agents 설치합니다.

### Download ZIP 이나 git clone 을 이용하여 설치합니다.

unity ml agents 설치 url : https://github.com/Unity-Technologies/ml-agents

![Alt text](/unity_ml_agents_guide/2.unity_ml_agent_download/unity_ml_agent_download.png)
- - -

## 3. 새 프로젝트를 생성합니다.

### 3-1. 설치된 unity를 실행하고 New를 눌러 새 프로젝트를 생성합니다.

![Alt text](/unity_ml_agents_guide/3.create_new_project/1.create_new_project.png)

### 3-2. 프로젝트명과 프로젝트 경로를 설정하고 생성합니다.

![Alt text](/unity_ml_agents_guide/3.create_new_project/2.set_project_name_and_loaction.png)

### 3-3. 프로젝트를 실행합니다.
#### * Layout 은 개인설정에 따라 다를 수 있습니다.

![Alt text](/unity_ml_agents_guide/3.create_new_project/3.complete.png)
- - -

## 4. unity ml agents를 import 합니다.

### 4-1. 위에서 설치한 ml agents 경로로 이동합니다.
ml agents 폴더에서 unity-environment 의 Assets 폴더로 이동합니다.

ml-agents/unity-environment/Assets

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/1.find_ML-Agents.png)

### 4-2. ML-Agents 폴더를 unity의 Project창에 드래그하여 import합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/2.import_ML-Agents.png)

### 4-3. 아래와 같은 Error가 나는 지 확인합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/3.confirm_error.png)

### 4-4. Edit -> Project Settings -> Player 설정으로 이동합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/4.edit_project_settings_players.png)

### 4-5. Inspector창이 바뀐걸 확인하고, Resolution and Presentation 탭의 설정을 아래와 같이 변경합니다.

Run In Background -> 체크

Display Resolution Dialog -> Disabled

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/5.resolution_and_presentation_setting.png)

### 4-6. 다음 Other Settings의 탭으로 이동하여 설정을 아래와 같이 변경합니다.

Scripting Runtime Version을 .NET 4.x 버전으로 바꿔줍니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/6.set_4.x.png)

### 4-7. 재시작을 하라는 창이 뜨면 Restart를 눌러 재시작 해줍니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/7.restart.png)

### 4-8. Other Setting 탭의 설정이 변경된 걸 확인하고 Scripting Define Symbols* 설정을 아래와 같이 변경합니다.

Scripting Runtime Version -> .NET 4.x Equivalent 로 변경
Api Compatibility Level* -> .NET 4.x 로 변경

Scripting Define Symbols* -> ENABLE_TENSORFLOW 입력

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/8.ENABLE_TENSORFLOW.png)

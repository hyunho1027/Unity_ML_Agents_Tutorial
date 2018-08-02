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
- - -

## 5. 학습할 환경을 구축합니다.

### 5-1. Hierarchy 창에 Cube를 생성합니다.

Hierarchy 창 우클릭 -> 3D Object -> Cube

![Alt text](/unity_ml_agents_guide/5.make_env/1.make_cube.png)

### 5-2. Cube의 설정을 변경합니다.

Hierarchy 의 Cube 클릭 -> Inspector창에서 이름 Platform 입력 -> Transform 정보 입력

![Alt text](/unity_ml_agents_guide/5.make_env/2.make_platform.png)

### 5-3. Platform 에 Rigidbody 설정을 추가합니다.

Hierarchy의 platform 클릭 -> Inspector창의 AddComponent 클릭 -> Rigidbody 입력 -> Rigidbody 클릭

![Alt text](/unity_ml_agents_guide/5.make_env/3.add_rigid_body.png)

### 5-4. Platform 의 Rigidbody 설정을 아래와 같이 변경합니다.

Hierarchy의 Platform 클릭 -> Inspector창의 Rigidbody 설정에서 Is Kinematic 체크

![Alt text](/unity_ml_agents_guide/5.make_env/4.Check_Is_Kinematic.png)

### 5-5. Hierarchy 창에 Sphere를 생성합니다.

Hierarchy 창 우클릭 -> 3D Object -> Sphere

![Alt text](/unity_ml_agents_guide/5.make_env/5.make_sphere.png)

### 5-6 Sphere의 설정을 변경합니다.

Hierarchy 의 Sphere 클릭 -> Inspector창에서 이름 Ball 입력 -> Transform 정보 입력

![Alt text](/unity_ml_agents_guide/5.make_env/6.make_ball.png)

### 5-7. Ball 에 Rigidbody 설정을 추가합니다.

Hierarchy의 Ball 클릭 -> Inspector창의 AddComponent 클릭 -> Rigidbody 입력 -> Rigidbody 클릭

![Alt text](/unity_ml_agents_guide/5.make_env/7.add_rigidbody.png)

### 5-8. Ball과 Platform에 색을 입히기 위해 Material을 2개 생성합니다.

Project창 우클릭 -> Create -> Material -> 이름을 Ball, Platform으로 변경

![Alt text](/unity_ml_agents_guide/5.make_env/8.make_material.png)

### 5-9. Ball Material을 Ball에 import 합니다.

Project 창의 Ball Material을 드래그하여 Hierarchy 창의 Ball에 옮깁니다.

![Alt text](/unity_ml_agents_guide/5.make_env/9.import_ballmaterial.png)

### 5-10. Platform Material을 Platform에 import 합니다.

Project 창의 Platform Material을 드래그하여 Hierarchy 창의 Platform에 옮깁니다.

![Alt text](/unity_ml_agents_guide/5.make_env/10.import_platformmaterial.png)

### 5-11. Ball Material로 Ball을 원하는 색으로 변경합니다.

Project 창의 Ball Material 클릭 -> Inspector의 Albedo 옆 상자 클릭 -> 원하는 색으로 설정

![Alt text](/unity_ml_agents_guide/5.make_env/11.change_ball_color.png)

### 5-12. Platform Material로 Platform을 원하는 색으로 변경합니다.

Project 창의 Platform Material 클릭 -> Inspector의 Albedo 옆 상자 클릭 -> 원하는 색으로 설정

![Alt text](/unity_ml_agents_guide/5.make_env/12.change_platform_color.png)
- - -

## 6. Academy와 Agent를 생성합니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/1.create_empty.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/2.create_guide_academy.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/3.create_empty2_in_guide_academy.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/4.create_guide_brain.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/5.create_C#.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/6.create_2C#.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/7.open_Guide_Academy.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/8.edit_Guide_Academy.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/9.edit_Guide_Agent.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/10.import_Guide_Academy.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/11.import_Brain.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/12.import_Guide_Agent.png)
![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/13.set_Guide_Agent.png)


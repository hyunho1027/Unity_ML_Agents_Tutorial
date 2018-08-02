# Unity_ML_Agents_Guide 
- - -

## 가이드 설명
- Unity ML Agents의 기본적인 사용법을 알아 봅니다.
- Unity ML Agents의 예제인 RollerBall을 직접 구현해봅니다.
- - -

- RollerBall

![Alt text](/unity_ml_agents_guide/sub/mb.gif)
- - -

## 진행 환경
- Windows10 64bit
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

### 6-1. Hierarchy 창에 Empty를 생성합니다.

Hierarchy창 우클릭 -> Create Empty 클릭

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/1.create_empty.png)

### 6-2. Empty Object 설정을 아래와 같이 변경합니다.

Hierarchy창의 GuideAcademy 클릭 -> Inspector창의 이름을 GuideAcademy로 변경

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/2.create_guide_academy.png)

### 6-3. GuideAcademy 에 새로운 Empty를 생성합니다.

Hierarchy의 GuiedAcademy 우클릭 -> Create Empty 클릭

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/3.create_empty2_in_guide_academy.png)

### 6-4. GuideAcademy 의 Empty Object 설정을 아래와 같이 변경합니다.

Hierarchy창의 GuideAcademy 왼쪽편 화살표를 클릭 -> 하위에 있는 Empty 클릭 ->  Inspector창의 이름을 GuideBrain으로 변경

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/4.create_guide_brain.png)

### 6-5. Project창에 GuideAcademy C# Script 와 GuideAgent C# Script 를 생성합니다.

Project창 우클릭 -> Create -> C# Script ->이름을 GuideAcademy로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

Project창 우클릭 -> Create -> C# Script ->이름을 GuideAgent로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/5.create_Script.png)

### 6-6. Project 창에 GuideAcademy, GuideAgent 생성 되었는지 확인합니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/6.created_2Scripts.png)

### 6-7. Project 창의 GuideAcademy를 더블클릭하여 실행합니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/7.open_Guide_Academy.png)

### 6-8. GuideAcademy C# Script 파일을 아래와 같이 작성합니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/8.edit_Guide_Academy.png)

### 6-9. GuideAgent도 같은 방식으로 실행하여 아래와 같이 작성합니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/9.edit_Guide_Agent.png)

### 6-10. GuideAcademy C# Script를 GuideAcademy에 import 합니다.

Hierarcy의 GuideAcademy 클릭 -> Inspector창의 AddComponent 클릭 -> GuideAcademy 입력 -> GuideAcademy 클릭

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/10.import_Guide_Academy.png)

### 6-11. Brain을 GuideBrain에 import 합니다.

Hierarcy의 GuideBrain 클릭 -> Inspector창의 AddComponent 클릭 -> Brain 입력 -> Brain 클릭

* Brain은 기본적으로 위에서 import한 ML-Agents에 있습니다.

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/11.import_Brain.png)

### 6-12. GuideAgent를 Platform 에 import 합니다.

Hierarcy의 Platform 클릭 -> Inspector창의 AddComponent 클릭 -> GuideAgent 입력 -> GuideAgent 클릭

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/12.import_Guide_Agent.png)

### 6-13. GuideAgent 설정을 아래와 같이 변경합니다.

Hierarchy 창의 Platform 클릭 -> Inspector 창의 Brain란에 Hierarchy창의 GuideBrain을 드래그하여 import -> Inspector 창의 Ball란에 Hierarchy창의 Ball을 드래그하여 import

![Alt text](/unity_ml_agents_guide/6.make_academy_and_agents/13.set_Guide_Agent.png)
- - -

## 7. Player Type으로 테스트합니다.

### 7-1. GuideBrain의 Brain Type을 Player로 변경하고 설정을 아래와 같이 변경합니다.

Hierarchy의 GuideBrain 클릭 -> Inspector창 Vector Observation 의 Space Type, Space Size 변경 -> Vector Action의 Space Type, Space Size 변경 -> Brain Type을 Player로 변경 -> Key Continuous Player Actions을 아래와 같이 변경

![Alt text](/unity_ml_agents_guide/7.test_player_mode/1.test_player_mode.png)

### 7-2. 위의 Play 를 눌러 실행합니다.

![Alt text](/unity_ml_agents_guide/7.test_player_mode/2.play.png)

### 7-3. 설정한 W, A, S, D 키를 이용하여 Platform을 조작해봅니다.

![Alt text](/unity_ml_agents_guide/7.test_player_mode/3.player_mode.gif)
- - -

## 8. External Type으로 변경하여 강화학습을 통해 학습시킵니다.

### 8-1. GuideBrain 의 Brain Type를 External로 변경합니다.

Hierarchy의 GuideBrain 클릭 -> Inspector창 Brain Type을 External 로 변경

![Alt text](/unity_ml_agents_guide/8.change_external_mode/1.change_external.png)

### 8-2. 현재 Scene을 저장합니다.

File 클릭 -> Save Scenes 클릭

![Alt text](/unity_ml_agents_guide/8.change_external_mode/2.save_scene.png)

### 8-3. 현재 저장된 Scene을 Build 합니다.

File 클릭 -> Build Settings... 클릭

![Alt text](/unity_ml_agents_guide/8.change_external_mode/3.build.png)

### 8-4. 현재 저장된 Scene을 체크하고 Build합니다.

체크할 Scene가 없다면 Project창의 Scenes의 왼쪽 삼각형을 클릭하면 나오는 SampleScene를 드래그하여 Scenes In Build 창으로 옮깁니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/4.check_build_option.png)

### 8-5. Build할 폴더를 지정합니다.

아래 화면은 Build를 누르면 나오는 기본 경로입니다. 저는 기본적으로 설정된 위치에 Build 하였습니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/5.select_build_location.png)

### 8-6. Build가 완료되었는지 확인합니다.

Build가 완료되면 아래와 같이 Build된 경로의 폴더가 열립니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/6.complete_build.png)

### 8-7. 직접 학습을 시키기 위해 첫 부분에 다운받았던 ml-agents의 python폴더로 이동합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/7.move_ml's_python.png)

### 8-8. 학습을 시작합니다.

ml-agents/python 에서 실행합니다.

python learn.py [Build Path]/[Project Name] --run-id=[Run Id] --train

을 통해 학습합니다.

ex. python learn.py [Build Path]/Guide_Project --run-id=Guide_1st --train

![Alt text](/unity_ml_agents_guide/8.change_external_mode/8.learn.png)

### 8-9. 학습이 잘 되고 있는지 Tensorboard를 이용하여 확인합니다.

ml-agents/python 에서 실행합니다.

tensorboard --logdir=summaries

를 이용하여 실행합니다.

아래와 같은 Url을 통해 Tensorboard에 접속합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/9.open_tensorboard.png)

### 8-10. Tensorboard를 모니터링 합니다.

Runs에서 자신이 실행한 Project Name을 클릭하여 확인합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/10.tensorboard.png)
- - -

## 9. 학습한 Model을 사용하기 위해 TFSharp를 설치합니다.

TFSharp 설치 Url : http://s3.amazonaws.com/unity-ml-agents/0.3/TFSharpPlugin.unitypackage

설치를 완료하고 실행합니다.

![Alt text](/unity_ml_agents_guide/9.download_TFSharp/1.TFSharp_down.png)
- - -

## 10. 학습이 완료된 Model을 Internal Type으로 실행합니다.

### 10-1. 학습이 완료되어 생긴 bytes 파일이 위치한 경로로 이동하여 bytes 파일을 복사합니다.

ml-agents/python/models/[Project Name]

ex. ml-agents/python/models/Guide_1st

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/1.find_byte_file.png)

### 10-2. 생성한 Guide Project의 Assets 폴더에 붙여넣기 합니다.

unity project를 생성한 경로의 Assets 폴더로 이동합니다.

bytes 파일을 붙여넣기 합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/2.move_byte_file.png)

### 10-3. unity의 Project 창에 bytes파일이 있는지 확인합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/3.confirm_byte_file.png)

### 10-4. GuideBrain Type을 Internal로 변경한 뒤 bytes파일을 import 합니다.

Hierarchy 의 GuideBrain 클릭 -> Inspector 창의 Brain Type을 Internal로 변경합니다. -> Graph Model에 bytes파일을 드래그하여 import 합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/4.import_byte_file.png)

### 10-5. play를 눌러 실행합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/5.play.png)

### 10-6. 직접 학습한 Model이 Platform을 직접 제어하는 것을 확인합니다.

아래의 model은 Agent를 최소한으로 코딩하여 만들어서 성능이 완벽하지 않습니다.

직접 코드를 추가하여 성능을 높여보세요.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/6.internal_mode.gif)
- - -

# 끝! 고생하셨습니다.

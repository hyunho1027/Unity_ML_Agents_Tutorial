# 4. unity ml agents를 import 합니다.
- - -

## 4-1. 위에서 설치한 ml agents 경로로 이동합니다.
ml agents 폴더에서 unity-environment 의 Assets 폴더로 이동합니다.

ml-agents/unity-environment/Assets

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/1.find_ML-Agents.png)
- - -

## 4-2. ML-Agents 폴더를 unity의 Project창에 드래그하여 import합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/2.import_ML-Agents.png)

## 4-3. 아래와 같은 Error가 나는 지 확인합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/3.confirm_error.png)
- - -

## 4-4. Edit -> Project Settings -> Player 설정으로 이동합니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/4.edit_project_settings_players.png)
- - -

## 4-5. Inspector창이 바뀐걸 확인하고, Resolution and Presentation 탭의 설정을 아래와 같이 변경합니다.

Run In Background -> 체크

Display Resolution Dialog -> Disabled

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/5.resolution_and_presentation_setting.png)
- - -

## 4-6. 다음 Other Settings의 탭으로 이동하여 설정을 아래와 같이 변경합니다.

Scripting Runtime Version을 .NET 4.x 버전으로 바꿔줍니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/6.set_4.x.png)
- - -

## 4-7. 재시작을 하라는 창이 뜨면 Restart를 눌러 재시작 해줍니다.

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/7.restart.png)
- - -

## 4-8. Other Setting 탭의 설정이 변경된 걸 확인하고 Scripting Define Symbols* 설정을 아래와 같이 변경합니다.

Scripting Runtime Version -> .NET 4.x Equivalent 로 변경
Api Compatibility Level* -> .NET 4.x 로 변경

Scripting Define Symbols* -> ENABLE_TENSORFLOW 입력

![Alt text](/unity_ml_agents_guide/4.import_ml_agents/8.ENABLE_TENSORFLOW.png)
- - -

## [NEXT_5. 학습할 환경을 구축합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Guide/tree/master/unity_ml_agents_guide/5.make_env)

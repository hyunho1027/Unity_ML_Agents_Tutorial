# 6. Academy와 Agent를 생성합니다.
- - -

## 6-1. Hierarchy 창에 Empty를 생성합니다.

Hierarchy창 우클릭 -> Create Empty 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/1.create_empty.png)
- - -

## 6-2. Empty Object 설정을 아래와 같이 변경합니다.

Hierarchy창의 GuideAcademy 클릭 -> Inspector창의 이름을 GuideAcademy로 변경

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/2.create_guide_academy.png)
- - -

## 6-3. Project창에 GuideAcademy C# Script 와 GuideAgent C# Script 를 생성합니다.

Project창 우클릭 -> Create -> C# Script ->이름을 GuideAcademy로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

Project창 우클릭 -> Create -> C# Script ->이름을 GuideAgent로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/3.create_Script.png)
- - -

## 6-4. Project 창에 GuideAcademy, GuideAgent 생성 되었는지 확인합니다.

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/4.created_2Scripts.png)
- - -

## 6-5. GuideAcademy C# Script 파일을 아래와 같이 작성합니다.

Project 창의 GuideAcademy를 더블클릭하여 실행합니다.
 
![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/5.edit_Guide_Academy.png)
- - -

## 6-6. GuideAgent도 같은 방식으로 실행하여 아래와 같이 작성합니다.

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/6.edit_Guide_Agent.png)
- - -

## 6-7. GuideAcademy C# Script를 GuideAcademy에 import 합니다.

Hierarcy의 GuideAcademy 클릭 -> Inspector창의 AddComponent 클릭 -> GuideAcademy 입력 -> GuideAcademy 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/7.import_Guide_Academy.png)
- - -

## 6-8. GuideAgent를 Platform 에 import 합니다.

Hierarcy의 Platform 클릭 -> Inspector창의 AddComponent 클릭 -> GuideAgent 입력 -> GuideAgent 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/8.import_Guide_Agent.png)
- - -

## 6-9. PlayerBrain을 만들어 줍니다.

Project 우클릭 -> Create -> ML-Agents -> Player Brain 클릭  
이름은 GuidePlayerBrain으로 하였습니다.

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/9.Make_PlayerBrain.png)
- - -

## 6-10. GuideAgent 설정을 아래와 같이 변경합니다.

Hierarchy 창의 Platform 클릭 -> Inspector 창의 Brain란에 Project창의 GuidePlayerBrain을 드래그하여 import -> Inspector 창의 Ball란에 Hierarchy창의 Ball을 드래그하여 import

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/13.set_Guide_Agent.png)
- - -

## [PREV_5. 학습할 환경을 구축합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/5.make_env)

## [NEXT_7. Player Type으로 테스트합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/7.test_player_mode)


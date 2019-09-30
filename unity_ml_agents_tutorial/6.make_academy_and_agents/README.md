# 6. Academy와 Agent를 생성합니다.
- - -

## 6-1. Hierarchy 창에 Empty를 생성합니다.

Hierarchy창 우클릭 -> Create Empty 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/1.create_empty.png)
- - -

## 6-2. Empty Object 설정을 아래와 같이 변경합니다.

Hierarchy창의 TutoAcademy 클릭 -> Inspector창의 이름을 TutoAcademy로 변경

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/2.create_Tuto_academy.png)
- - -

## 6-3. Project창에 TutoAcademy C# Script 와 TutoAgent C# Script 를 생성합니다.

Project창 우클릭 -> Create -> C# Script ->이름을 TutoAcademy로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

Project창 우클릭 -> Create -> C# Script ->이름을 TutoAgent로 설정 (변경이 아니라 초기에 설정하시길 권장합니다.)

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/3.create_Script.png)
- - -

## 6-4. Project 창에 TutoAcademy, TutoAgent 생성 되었는지 확인합니다.

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/4.created_2Scripts.png)
- - -

## 6-5. TutoAcademy C# Script 파일을 아래와 같이 작성합니다.(TutoAcademy.cs 참고)

Project 창의 TutoAcademy를 더블클릭하여 실행합니다.

(본 프로젝트에서는 별도의 Academy 설정 없이 진행합니다.)

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/5.edit_Tuto_Academy.png)
- - -

## 6-6. TutoAgent도 같은 방식으로 실행하여 아래와 같이 작성합니다.(TutoAgent.cs 참고)

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/6.edit_Tuto_Agent.png)
- - -

## 6-7. TutoAcademy C# Script를 TutoAcademy에 import 합니다.

Hierarcy의 TutoAcademy 클릭 -> Inspector창의 AddComponent 클릭 -> TutoAcademy 입력 -> TutoAcademy 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/7.import_Tuto_Academy.png)
- - -

## 6-8. TutoAgent를 Platform 에 import 합니다.

Hierarcy의 Platform 클릭 -> Inspector창의 AddComponent 클릭 -> TutoAgent 입력 -> TutoAgent 클릭

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/8.import_Tuto_Agent.png)
- - -

## 6-9. PlayerBrain을 만들어 줍니다.

Project 우클릭 -> Create -> ML-Agents -> Player Brain 클릭  
이름은 TutoPlayerBrain으로 하였습니다.

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/9.Make_PlayerBrain.png)
- - -

## 6-10. TutoAgent 설정을 아래와 같이 변경합니다.

Hierarchy 창의 Platform 클릭 -> Inspector 창의 Brain란에 Project창의 TutoPlayerBrain을 드래그하여 import -> Inspector 창의 Ball란에 Hierarchy창의 Ball을 드래그하여 import

![Alt text](/unity_ml_agents_tutorial/6.make_academy_and_agents/10.set_Tuto_Agent.png)
- - -

## [PREV_5. 학습할 환경을 구축합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/5.make_env)

## [NEXT_7. Player Type으로 테스트합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/7.test_player_mode)


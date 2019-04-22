# 9. 학습이 완료된 Model을 Internal Type으로 실행합니다.
- - -

## 9-1. 학습이 완료되어 생긴 nn 파일을 unity의 Project창의 Assets폴더에 드래그하여 import합니다.

ml-agents/models/[Project Name]

ex. ml-agents/models/Guide_1st

![Alt text](/unity_ml_agents_tutorial/9.change_internal_mode/1.find_nn_file.png)
- - -

## 9-2. GuideLearningBrain에 nn파일을 import 합니다.

Project의 GuideLearningBrain 클릭 -> Inspector 창의 Model에 nn파일을 드래그하여 import 합니다.  

Inference Device는 각자 맞는 장치로 설정합니다.

![Alt text](/unity_ml_agents_tutorial/9.change_internal_mode/4.import_nn_file.png)
- - -

## 9-3. GuideAcademy의 Brain Control 체크를 해제해줍니다.

![Alt text](/unity_ml_agents_tutorial/9.change_internal_mode/5.noncontrol.png)
- - -

## 9-4. 학습한 Model이 Platform을 직접 제어하는 것을 확인합니다.

아래의 model은 Agent를 최소한의 코딩으로 만들어서 성능이 완벽하지 않습니다.

직접 코드를 추가하여 성능을 높여보세요.

![Alt text](/unity_ml_agents_tutorial/9.change_internal_mode/6.internal_mode.gif)
- - -

# 끝! 고생하셨습니다.

## [PREV_8. External Type으로 변경하여 강화학습을 통해 학습시킵니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/8.change_external_mode)

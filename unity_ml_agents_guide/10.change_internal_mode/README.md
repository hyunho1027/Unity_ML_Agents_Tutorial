# 10. 학습이 완료된 Model을 Internal Type으로 실행합니다.
- - -

## 10-1. 학습이 완료되어 생긴 bytes 파일이 위치한 경로로 이동하여 bytes 파일을 복사합니다.

ml-agents/python/models/[Project Name]

ex. ml-agents/python/models/Guide_1st

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/1.find_byte_file.png)
- - -

## 10-2. 생성한 Guide Project의 Assets 폴더에 붙여넣기 합니다.

unity project를 생성한 경로의 Assets 폴더로 이동합니다.

bytes 파일을 붙여넣기 합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/2.move_byte_file.png)
- - -

## 10-3. unity의 Project 창에 bytes파일이 있는지 확인합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/3.confirm_byte_file.png)
- - -

## 10-4. GuideBrain Type을 Internal로 변경한 뒤 bytes파일을 import 합니다.

Hierarchy 의 GuideBrain 클릭 -> Inspector 창의 Brain Type을 Internal로 변경합니다. -> Graph Model에 bytes파일을 드래그하여 import 합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/4.import_byte_file.png)
- - -

## 10-5. play를 눌러 실행합니다.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/5.play.png)
- - -

## 10-6. 학습한 Model이 Platform을 직접 제어하는 것을 확인합니다.

아래의 model은 Agent를 최소한의 코딩으로 만들어서 성능이 완벽하지 않습니다.

직접 코드를 추가하여 성능을 높여보세요.

![Alt text](/unity_ml_agents_guide/10.change_internal_mode/6.internal_mode.gif)
- - -

# 끝! 고생하셨습니다.

## [PREV_9. 학습한 Model을 사용하기 위해 TFSharp를 설치합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Guide/tree/master/unity_ml_agents_guide/9.download_TFSharp)

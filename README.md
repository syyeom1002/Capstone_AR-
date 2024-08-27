
# [잘조립 Portfolio]


## 1. 프로젝트 소개

<div align="center">

  <img src="https://github.com/user-attachments/assets/7d42f6f3-676e-4d22-ac5c-99d1500a22bf" width="30%" height="380"/>
  <img src="https://github.com/user-attachments/assets/fc94570a-0fa1-4358-9d1d-70d4189d9f81" width="30%" height="380"/>
  <img src="https://github.com/user-attachments/assets/bcf4ec01-1e57-49a9-8721-ad32e5d6c390" width="30%" height="380"/>
  <img src="https://github.com/user-attachments/assets/8431a7ea-f83d-4e6a-b029-e651fd9fe05d" width="90%" height="400"/>


</div>

> + 졸업 작품으로 진행한 프로젝트 입니다. 잘조립은 종이 가구 조립 설명서의 불편함을 없애고자 만든 어플리케이션 입니다. 
> 어플에 접속하여 핸드폰 카메라로 가구의 바코드나 설명서에 있는 완성된 가구의 입체도 또는 사진 등을 인식하면, 해당 가구의 조립법을 증강현실(AR)을 이용하여 가구의 조립 순서대로 3D로 띄워줍니다. 
> 국적과 나이 관계없이 사용자들이 설명서를 직접적으로 이해하지 않아도 가구조립을 보다 쉽게 할 수 있습니다. 또한 핸드폰을 이용하여 설명서를 보기 때문에 종이 소비를 줄일 수 있습니다. 
> 
> + 개발기간: 2022.03.07 ~ 2022.06.03 ( 약 3개월 )


<br>

## 2. 개발 환경

+ 개발 엔진 : Unity, Android Studio , Vuforia, 3ds max

+ 언어 : C#, Kotiln

+ 플랫폼 : Android


<br>

## 3. 사용 기술
| 기술 | 설명 |
|:---:|:---|
| Image Targets | Grab, OVRInput, Haptics, Hand Grab Pose, Ray |
| modeling | 미션 UI의 팔로우 로직 및 방패 찍기 구현 |
| Prefab | scrollView와 더불어 캐릭터 선택 UI 구현 |
| Rigidbody, Collider | 성능의 최적화를 위해 라이트맵을 이용하여 게임 맵 구성 fps 40->60 |
| 바코드스캐너 | 방패 던지기 방향 구현 |

<br>

## 4. 개발 인원 및 담당

+ 인원 : 총 4인 (Unity 2인, Android 2인)
+ 담당 : 팀장, 가구 부품 모델링, 가구의 이동(설명서의 짝수 번호)

<br>

## 5. 핵심 기능


#### 바코드 스캔
 //영상 필요

+ Controller의 Thumbstick 으로 좌우 이동
+ Controller의 A버튼 클릭하면 캐릭터 선택 완료, 게임씬으로 전환


#### 설명서 링크 다운로드
<div align="center">

  //영상 필요

</div>

+ 자동 이동
+ Leap : Contoller의 A 버튼을 이용하여 이동 가능


#### AR 설명서 실행
<div align="center">

  <img src="https://github.com/user-attachments/assets/e561759c-4568-4fc2-9fe4-ba2b972b0adb" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/a9fb460c-7c83-4f43-928b-f6cc181c6bed" width="49%" height="280"/>

</div>

+ 방패 던지기 : Controller의 HandTrigger버튼으로 조작 가능
+ 방패 찍기 : Controller의 IndexTrigger 버튼으로 조작 가능


<br>



## 8. 플레이 영상
+ https://www.youtube.com/watch?v=zeMj6LFLNMg
+ 

---

**담당한 부분(작성한 스크립트)**

짝수 Step 구현 (2,4,6,8,10,12)


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
| Image Targets | 도면 인식 |
| modeling | 구현하고자 하는 가구 모델링 |
| Prefab | 부품들 생성 |
| Rigidbody, Collider | 부품끼리 충돌 확인 |

<br>

## 4. 개발 인원 및 담당

+ 인원 : 총 4인 (Unity 2인, Android 2인)
+ 담당 : 팀장, 가구 부품 모델링, 가구의 이동(설명서의 짝수 번호,Unity 담당)

<br>

## 5. 핵심 기능


#### 모델링
<div align="left">

  <img src="https://github.com/user-attachments/assets/56041ca8-61bb-47a4-af47-b767978143c9" width="35%" height="380"/>
  <img src="https://github.com/user-attachments/assets/0d85af17-681d-40ac-ad4e-53704b76ab70" width="35%" height="380"/>

</div>

+ 최대한 실제와 같도록 모델링

#### 바코드 스캔
 //영상 필요

+ QR Code 버튼 클릭하면 QR코드 스캐너가 나옴 


#### 설명서 링크 다운로드
<div align="left">

  //영상 필요

</div>

+ Menual 버튼 클릭하면 설명서 pdf 파일 다운로드 가능


#### AR 설명서 실행
<div align="left">

  <img src="https://github.com/user-attachments/assets/35ade444-bde5-4033-82dc-646a1d8b232e" width="35%" height="380"/>
  <img src="https://github.com/user-attachments/assets/36fedaba-9c35-40b8-9448-b71c5c2692ac" width="35%" height="380"/>

</div>
<div align="left">

  <img src="https://github.com/user-attachments/assets/d831e98f-870f-46f6-a72f-cd86649d45ee" width="35%" height="380"/>
  <img src="https://github.com/user-attachments/assets/ac53342f-41f9-4071-a2ea-998ef8264cf8" width="35%" height="380"/>

</div>

+ Funiture 버튼 글릭하면 AR 설명서 실행
+ 도면을 인식하면 증강현실로 설명서를 볼 수 있다.


<br>



## 8. 플레이 영상
+ https://www.youtube.com/watch?v=zeMj6LFLNMg

---

**담당한 부분(작성한 스크립트)**

짝수 Step 구현 (2,4,6,8,10,12)

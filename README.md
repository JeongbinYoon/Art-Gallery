# XR 갤러리, 영화 박물관
## 기획 의도
우연히 움직이는 AR 포스터를 접하게 되었고 더 유용하게 활용해볼 수 있지 않을까 하는 생각에 3D전시장을 기획하였다. 공공데이터를 활용하는 것과 3D 콘텐츠에도 관심이 있었기에 2가지 씬으로 제작하였다. 
전시장이다 보니 다른 사용자들과 함께할 수 있도록 하고 싶어 매치메이킹 멀티플레이를 구현하기 위하여 Photon PUN2에 대해 알아보고 적용시켰다. 보다 멀티플레이를 생동감 있게 구현하기 위하여 채팅 기능도 추가하였다.

## 사용 기술
<img src="https://img.shields.io/badge/Unity-black?style=flat&logo=Unity&logoColor=white"/> <img src="https://img.shields.io/badge/C Sharp-239120?style=flat&logo=C Sharp&logoColor=white"/> 
## 사용 공공데이터
문화공공데이터광장_3D 콘텐츠

## 프로젝트 설명
XR 갤러리와 영화 박물관이다. Unity 프로젝트로 C# 스크립트로 개발했으며 멀티플레이를 위해 Photon PUN2를 사용했다. 로비에서 캐릭터를 선택하면 XR 갤러리 씬으로 넘어가게 된다. 갤러리에서는 AR 기능이 탑재된 포스터를 전시해두었다. 스마트폰 어플을 통해 보면 움직이는 무빙포스터를 감상할 수 있다. 방향키로 캐릭터를 움직일 수 있도록 하고 모션을 적용했다. <br/><br/>
박물관 씬에서는 한국문화정보원 문화 공공데이터 광장에서 제공하는 3D 공공데이터를 활용하여 박물관을 구성하였고 가까이 다가가거나 재생 버튼에 서게 되면 해당 데이터의 정보를 음성으로 읽어줄 수 있도록 개발하였다.

# 구현 사항
+ 로비
+ XR 갤러리
+ 박물관

***

> ### 로비<br/>
프로젝트 실행시 첫 화면이다. 5개의 캐릭터를 선택할 수 있다. 캐릭터를 선택하면 XR 갤러리 씬으로 이동하며 해당 캐릭터가 생성된다. 멀티플레이를 구현하기 위해 Photon PUN2를 사용했고 하나의 룸에 최대 4명까지만 입장이 가능하다. 같은 룸에 5명 이상이 입장하게 되면 같은 씬의 새로운 룸이 생기게 된다. <br/>
<br/>
<img src="https://user-images.githubusercontent.com/86540140/207012884-c35c3f52-6871-432e-a3e7-35d44e526e1a.png" width="910"><br/>

<br/><br/>
> ### XR 갤러리
Photon을 통해 다른 사용자가 움직이는 위치와 애니메이션을 볼 수 있도록 하였다. 왼쪽 상단에는 채팅을 할 수 있도록 하였으며 채팅시 닉네임은 로비에서 선택한 캐릭터의 이름으로 설정된다. 선택한 캐릭터는 방향키로 이동과 회전이 가능하다. 이동시 Shift를 누르면 달리는, Ctrl을 누르면 걷는 모션과 속도를 적용하였다. 
갤러리에서는 AR 기능이 탑재된 포스터를 전시해두었다. 스마트폰 어플을 Artivive를 통해 전시된 포스터를 보면 움직이는 무빙포스터를 감상할 수 있다.
<br/><br/>
<img src="https://user-images.githubusercontent.com/86540140/206998006-c7329207-96b1-49fe-b315-95213fa7b100.png" width="760"><br/>
<img src="https://user-images.githubusercontent.com/86540140/206999572-05065d52-e6cc-4c83-b0fc-57f128dd7f4c.jpeg" width="250"> <img src="https://user-images.githubusercontent.com/86540140/207000319-167ddc65-55d6-41eb-9c74-59f6f5b1d255.jpeg" width="250">
<img src="https://user-images.githubusercontent.com/86540140/207000482-df7e938e-0387-4257-8112-07870462fcbb.jpeg" width="250">


<br/><br/>
> ### 영화 박물관
문화공공데이터광장의 3D 데이터를 활용하여 구성한 박물관이며 역사, 의상, 수상 3가지의 구역으로 나뉘어있다. 재생, 일시정지 버튼이 있는 데이터는 캐릭터와 버튼의 접촉 여부에 따라 해당 데이터의 정보를 읽어준다. 해당 정보 또한 문화공공데이터광장에서 제공받았으며 TTS를 통해 텍스트를 음성으로 변환하여 버튼 컴포넌트에 전달 후 재생, 일시정지의 기능을 수행한다.
<br/><br/>
<img src="https://user-images.githubusercontent.com/86540140/207016239-7421bed0-d33f-49eb-8ccf-bfa7ec2774cb.png" width="760"><br/>
<img src="https://user-images.githubusercontent.com/86540140/207016291-08823544-4895-40cd-93cf-eec35735363b.png" width="250"> <img src="https://user-images.githubusercontent.com/86540140/207016280-f5b894a4-7681-4805-b604-a786d5c0dd28.png" width="250">
<img src="https://user-images.githubusercontent.com/86540140/207016307-64d03eeb-522a-4753-a75f-135a48117f67.png" width="250">


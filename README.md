**********Cách Triển Khai************
Bước 1: Cài đặt Unity. Tham khảo tại đây (https://cellphones.com.vn/sforum/unity-la-gi#:~:text=C%C3%A1ch%20t%E1%BA%A3i%20Unity,Finish%E2%80%9D%20%C4%91%E1%BB%83%20ho%C3%A0n%20t%E1%BA%A5t%E2%80%9D.)
Bước 2: Tải project trên github về và giải nén.
Bước 3: Mở Unity Hub và tạo project mới với template là 3D Core.
Bước 4: Copy 3 thư mục Assets, Packages, ProjectSettings vào project vừa tạo và ghi đè lên.
Bước 5: Mở project vừa tạo với Unity Hub. Khuyên dùng phiên bản Unity 2021.3.24f1 trở lên.
Bước 6: Bấm Play trong Unity Editor để trải nghiệm.


****************Mô Tả*******************************
Có 3 cách để thay đổi vị trí của mặt trời.

Cách 1: Sử dụng toạ độ. Ở đây, chúng ta dùng kinh độ và vĩ độ. Mặt chơi sẽ chiếu sáng vào vị trí có kinh độ và vĩ độ tương ứng. Để thực hiện ta làm như sau:
	Bước 1: Nhập kinh độ và vĩ độ. Nếu nhập toạ độ nhỏ hơn -180 độ thì sẽ tự động chuyển thành -180 độ, nếu nhập lớn hơn 180 độ thì sẽ tự động chuyển thành 180.
		Nếu bỏ trống không nhập thì tự động set giá trị mặc định là 0.
		Điều này là sự ràng buộc nhằm tránh trường hợp người dùng nhập sai.
	Bước 2: Nhấn nút Thay Đổi bên cạnh và xem kết quả.

Cách 2: Sử dụng thời gian. Ở đây, mặt trời sẽ thay đổi theo thời gian trong ngày. Để thực hiện ta làm như sau:
	Bước 1: Nhập thời gian, ngày, tháng. 
		Nếu thời gian nhỏ hơn 1 thì sẽ tự động đổi thành 1, còn lớn hơn 24 sẽ tự động đổi thành 24.
		Nếu ngày nhỏ hơn 1 sẽ tự động đổi thành 1, còn lớn hơn 31 sẽ tự động đổi thành 31.
		Nếu tháng nhỏ hơn 1 sẽ tự động thành 1, còn nếu lớn hơn 12 sẽ tự động đổi thành 12.
	Bước 2: Nhấn nút Thay Đổi bên cạnh và xem kết quả.

Cách 3: Sử dụng thời gian thực. Ở đây, mặt trời sẽ thay đổi theo thời gian thực của chúng ta. Điều này phục thuộc vào thời gian trong hệ thống của máy tính đang sử dụng.
	Để thực hiện ta làm như sau: Nhấn nút Thời Gian Thực và xem kết quả.
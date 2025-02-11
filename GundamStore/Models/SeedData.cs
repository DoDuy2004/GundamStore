using Microsoft.EntityFrameworkCore;

namespace GundamStore.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var scope = serviceProvider.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<StoreDbContext>();

				if (context.Database.GetPendingMigrations().Any())
				{
					context.Database.Migrate();
				}

				if (!context.Blogs.Any())
				{
					context.Blogs.AddRange(
						new Blog
						{

							Author = "Thanh Tú",
							Title = "Tìm hiểu về Omega - Đối tác tin cậy của tín đồ mô hình",
							Thumbnail = "blog8.jpg",
							Slug = "tim-hieu-ve-omega-doi-tac-tin-cay-cua-tin-do-mo-hinh",
							ShortContent = "",

							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#noi-dung'>1. Giới thiệu về công ty</a></li>
                                                <li><a href='#dat-hang-hop-le'>2. Chính sách thanh toán</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>3. Chính sách giao hàng</a></li>
                                                <li><a href='#luu-y'>4. Chính sách hoàn trả</a></li>

                                          </ul>",
							Content = @"<div class='main-content'>
                            <h4 class='font-weight-bold' id='noi-dung'>
                            1. Giới thiệu về công ty
                            </h4>
                                  <p>
                                        Omega là cửa hàng bán mô hình chuyên về các sản phẩm mô hình nhựa,mô hình kim loại,mô hình giấy 3d với đa dạng loại sản phẩm.
                                        Với phương châm kinh doanh luôn đặt khách hàng lên hàng đầu, Cửa hàng Omega luôn cố gắng
                                        mang lại giá sản phẩm ổn định và đảm bảo có nguồn hàng sẵn cho quý khách hàng.
                                        Cố gắng vì khách hàng là động lực để cửa hàng cố gắng phát triển.
                                  </p>
                              
                                  <p>
                                        Bạn có thể ghé qua cửa hàng Omega tại địa chỉ : <strong> Đ. Huỳnh Thúc Kháng, Bến Nghé, Quận 1.</strong>
                                  </p>

                                  <p>
                                        Bạn có thể liên hệ với cửa hàng thông qua SĐT: <strong>0123.456.789.</strong>
                                  </p>
                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                            2. Chính sách thanh toán
                            </h4>
                                  <p>
                                    - Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 2 hình thức thanh toán: COD, MOMO.
                                  </p>
                                  <p>
                                    - Phương thức thanh toán COD :
                                    COD (Cash on delivery) là phương thức nhận hàng rồi mới thanh toán, cũng là một phương thức được ưa chuộng nhất hiện nay.
                                    Ưu điểm của phương thức này là các bạn sẽ thanh toán chỉ khi nhận được hàng (bao gồm chi phí mua hàng + phí ship).
                                  </p>
                                  <p>
                                    - Phương thức thanh toán qua ví MOMO :
                                     <br>
                                        SĐT nhận: 0204466312 
                                        Họ tên: Nguyễn Duy Thanh Tú
                                     <br>
                                        Nội dung chuyển tiền với cú pháp sau: [Họ tên] mua [danh sách mã sản phẩm] hoặc [mã đơn hàng]
                                        <br>Ví dụ: Nguyễn Văn A thanh toán đơn #12345.
                                  </p>


                              <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                3. Chính sách giao hàng
                              </h4>
                                  <p>
                                    - Quá trình giao nhận hàng :

                                    Omega hợp tác với những đơn vị vận chuyển đáng tin cậy để giao hàng trực tiếp đến quý khách trên phạm vi toàn quốc.

                                    Chúng tôi sử dụng dịch vụ Giao Hàng Tiết Kiệm theo tiêu chí, nhanh và rẻ.

                                    Tại thời điểm nhận hàng, quý khách có thể kiểm tra tình trạng, số lượng các sản phẩm trong đơn đặt hàng.    
                                        <br>
                                    - Chi phí vận chuyển :

                                    Đồng giá phí ship 25k cho mọi đơn hàng.
                                       <br>

                                    - Thời gian giao nhận hàng :

                                    Omega sẽ vận chuyển hàng trong thời gian thỏa thuận khi quý khách thực hiện đầy đủ các thủ tục đặt hàng. Thời gian vận chuyển hàng trong vòng 2 - 3 ngày làm việc (không tính chủ nhật hay các ngày lễ Tết). Thời gian nhận hàng từ 1 - 2 ngày đối với nội thành Tp. Hồ Chí Minh và từ 3 - 5 ngày đối với tỉnh thành khác.

                                    Xin lưu ý rằng Omega bảo lưu quyền thay đổi thời gian giao hàng trong một số trường hợp bất khả kháng như thời tiết xấu, điều kiện giao thông không thuận lợi, xe hỏng trên đường giao hàng, trục trặc trong quá trình xuất hàng. Chúng tôi sẽ chủ động liên hệ với khách hàng để thông báo trong những trường hợp trên.

                                    Mọi chi tiết xin liên hệ thông qua SĐT: <strong>0123.456.789</strong> hoặc qua Email: <strong>mohinhOmega@gmail.com.</strong>
                                </p>
                                <h4 class='font-weight-bold' id='luu-y'>4. Chính sách hoàn trả</h4>
                                  <p>
                                    - Điều kiện đổi trả :
                                    Quý Khách hàng cần kiểm tra tình trạng hàng hóa và có thể đổi hàng/ trả lại hàng ngay tại thời điểm giao/nhận hàng trong những trường hợp sau:
                                  <ul>
                                    <li>Hàng không đúng chủng loại, mẫu mã trong đơn hàng đã đặt hoặc như trên website tại thời điểm đặt hàng.</li>
                                    <li> Không đủ số lượng, không đủ bộ như trong đơn hàng.</li>
                                    <li> Tình trạng bên ngoài bị ảnh hưởng như rách bao bì, bong tróc, bể vỡ…</li>
                                  </ul>
                                  Khách hàng có trách nhiệm xuất trình Video và hình ảnh chứng minh sự thiếu sót trên để hoàn thành việc hoàn trả/đổi trả hàng hóa.
                                  </p>
                                  <p>
                                    <i>
                                      Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                    </i>
                                  </p>
                                  <p>
                                    Quy định về thời gian thông báo và gửi sản phẩm đổi trả
                                  <ul>
                                    <li>Thời gian thông báo đổi trả: trong vòng 48h kể từ khi nhận sản phẩm đối với trường hợp sản phẩm thiếu phụ kiện, quà tặng hoặc bể vỡ.</li>
                                    <li>Thời gian gửi chuyển trả sản phẩm: trong vòng 7 ngày kể từ khi nhận sản phẩm.</li>
                                    <li>Chúng tôi không chấp nhận yêu cầu hoàn tiền dưới mọi hình thức</li>
                                  </ul>
                                  </p>
                                  <p>
                                    Sau khi xác nhận các điều kiện trên và nhận được sản phẩm, cửa hàng sẽ tiến hành đổi lại và giao sản phẩm khác cho quý khách.
                                  </p>
                                  <p>
                                    Trong trường hợp Quý Khách hàng có ý kiến đóng góp/khiếu nại liên quan đến chất lượng sản phẩm.
                                    Quý Khách hàng vui lòng liên hệ thông qua số điện thoại:<strong>0123.456.789</strong>
                                  </p>

                                </div>",

							CreatedAt = DateTime.Now.AddDays(-11)
						},
						new Blog
						{

							Author = "Đỗ Duy",
							Title = "Mua kèm deal sốc - giảm đến 70%",
							Thumbnail = "blog1.jpg",
							Slug = "mua-kem-deal-soc-giam-den-70",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#dat-hang-hop-le'>3. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>4. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>5. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>6. Câu hỏi thường gặp</a></li>
                                            </ul>",
							ShortContent = "Mua kèm deal sốc hơn 130 sản phẩm HOT giảm giá đến 70% khi mua sắm với hóa đơn từ 299K . Áp dụng từ 7.1 ~ 15/1. FREESHIP với đơn từ 290K",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>1. Thời gian</h4>
                                            <p>
                                                Từ <strong>7.1</strong> đến hết ngày <strong>15.1</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua sắm với hóa đơn từ <strong>299k</strong>, quý khách sẽ
                                                được tham gia chương trình Mua Kèm Deal Sốc hơn 130 sản phẩm
                                                HOT với giá giảm đến 70%
                                            </p>
                                            <p>
                                                Danh sách sản phẩm thuộc chương trình
                                                <strong>Deal Sốc 2025</strong> quý khách xem tại đây:
                                                <a href='#'>https://omega.vn/collections/deal-soc-2024/</a>
                                            </p>
                                            <p class='font-weight-bold'>Cụ thể như sau:</p>
                                            <p>
                                                - Hóa Đơn (HD) từ <strong>299k</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 99k</span> chỉ với giá
                                                <strong>99k</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 299K</span> chỉ với giá
                                                <strong>299K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>699K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 499K</span> chỉ với giá
                                                <strong>499K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>899K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 699K</span> chỉ với giá
                                                <strong>699K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1099K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 899K</span> chỉ với giá
                                                <strong>899K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 1099K</span> chỉ với giá
                                                <strong>1099K</strong>
                                            </p>
                                            <p>
                                                <i>Áp dụng mua nhiều sản phẩm Deal Sốc trên cùng 1 hóa đơn</i>
                                            </p>
                                            <p><i>Không giới hạn số lần mua sắm</i></p>
                                            <p><i>Áp dụng FREESHIP đối với hóa đơn từ 290K</i></p>
                                            <p>
                                                <i>
                                                    Không áp dụng sản phẩm Deal Sốc đối với các chương trình
                                                    khuyến mãi khác. Quyền quyết định cuối cùng thuộc về
                                                    Omega
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                <strong>Ví dụ: </strong>Khách hàng mua 3 sản phẩm trong giỏ
                                                hàng (sản phẩm A = 400.000đ, sản phẩm B = 600.00đ, sản phẩm C
                                                = 500.000đ)
                                            </p>
                                            <p>
                                                Tổng hóa đơn: 1.500.000đ, áp voucher giảm 4% (60K) => Tổng
                                                thanh toán: 1.440.000 đ
                                            </p>
                                            <p>
                                                Quý khách hàng được tham gia chương trình
                                                <strong>Deal Sốc 2024</strong> linh hoạt như sau:
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 1: mua 4 sản phẩm trong danh sách Deal Sốc 99K,
                                                tổng đơn: 1.440.000 đ + (99.000 * 4) = 1.836.000đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 2: mua 2 sản phẩm trong danh sách Deal Sốc 299K và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + (299.000 đ * 2) + 99.000 đ = 2.137.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 3: mua 2 sản phẩm trong danh sách Deal Sốc 499k,
                                                tổng đơn: 1.440.000 đ + (499.000 đ * 2) = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 4: mua 1 sản phẩm trong danh sách Deal Sốc 699K và
                                                1 sản phẩm trong danh sách Deal Sốc 299K, tổng đơn: 1.440.000
                                                đ + 699.000 đ + 299.000 đ = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 5: mua 1 sản phẩm trong danh sách Deal Sốc 899k và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + 899.000 đ + 99.000 đ = 2.438.000 đ
                                            </p>
                                            <p>
                                                Quý khách có thể tự linh động kết hợp tùy vào giá trị hóa đơn,
                                                có thể mua 1 hoặc nhiều sản phẩm Deal Sốc.
                                            </p>
                                            <p>
                                                Trong trường hợp quý khách hàng gặp khó khăn hoặc chưa nắm rõ
                                                về chương trình. Vui lòng liên hệ Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>Đối với hóa đơn từ 290K, quý khách sẽ được FREESHIP</i>
                                            </p>
                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                                4. Đối tượng tham gia
                                            </h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua
                                                Fanpage Facebook và đặt hàng trên Website
                                                <a href='#'>https://omega.vn</a>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>5. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Không áp dụng đổi trả, bảo hành đối với sản phẩm tham gia
                                                    chương trình <strong>Deal Sốc 2024</strong>
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                6. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm AP cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-12)
						},
						new Blog
						{

							Author = "Tấn Phát",
							Title = "[BLACK FRIDAY] GIẢM ĐẾN 70% - NGẬP TRÀN ƯU ĐÃI",
							Thumbnail = "blog2.jpg",
							Slug = "black-friday-giam-den-70-ngap-tran-uu-dai",
							ShortContent = "Giảm giá đến 70% toàn bộ mô hình lắp ráp 3D khi đặt hàng thành công tại website OmegaShop. FREESHIP với đơn từ 290K",
							ListContent = @"<ul class='menu pl-3 mt-3'>              
                                        <li><a href='#noi-dung'>1. Nội dung chương trình</a></li>
                                        <li><a href='#dat-hang-hop-le'>2. Cách thức đặt hàng hợp lệ</a></li>
                                        <li><a href='#doi-tuong-tham-gia'>3. Đối tượng tham gia</a></li>
                                        <li><a href='#luu-y'>4. Lưu ý</a></li>
                                        <li><a href='#cau-hoi'>5. Câu hỏi thường gặp</a></li>
                                    </ul>",
							Content = @"<div class='main-content'>
                                <h4 class='font-weight-bold' id='noi-dung'>
                                    1. Nội dung chương trình
                                </h4>
                                <p>
                                    Giảm giá đến <strong>70%</strong>, với tất cả sản phẩm  tại OmegaShop. Giá sản phẩm tại website là giá đã giảm.
                                </p>
                                <p>
                                    Xem toàn bộ mô hình tại đây:
                                    <a asp-controller='Product' asp-action='Index'>Sản phẩm</a>
                                </p>
                                <p>
                                    Áp dụng
                                    <strong>FREESHIP</strong> đối với hóa đơn từ<strong>290K</strong>

                                </p>
                                <p>
                                    <i>Không áp dụng đối với các chương trình khuyến mãi khác. Quyền quyết định cuối cùng thuộc về Art Puzzle</i>
                                </p>

                                <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                    2. Cách thức đặt hàng hợp lệ
                                </h4>
                                <p>
                                    Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                </p>

                                <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                    3. Đối tượng tham gia
                                </h4>
                                <p>
                                    Tất cả khách hàng mua tại showroom, mua online thông qua
                                    Fanpage Facebook và đặt hàng trên Website
                                    <a href='#'>Omega</a>
                                </p>
                                <h4 class='font-weight-bold' id='luu-y'>4. Lưu ý</h4>
                                <p>
                                    Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                    trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                    <strong>090 8427608</strong> (Mr. Duy)
                                </p>
                                <p>
                                    <i>
                                        Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                    </i>
                                </p>
                                <h4 class='font-weight-bold' id='cau-hoi'>
                                    5. Câu hỏi thường gặp
                                </h4>
                                <p>
                                    <strong>
                                        Q: Đơn gốc của mình trên 290k có được miễn ship
                                        không?
                                    </strong><br /><span>A: Có</span>
                                </p>
                                <p>
                                    <strong>
                                        Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                        gì?
                                    </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                </p>
                                <p>
                                    <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                </p>
                            </div>",

							CreatedAt = DateTime.Now.AddDays(-11)
						},
						new Blog
						{

							Author = "Phương Nam",
							Title = "Nhân Đôi Ưu Đãi – Mừng Xuân Giáp Thìn",
							Thumbnail = "blog3.jpg",
							Slug = "nhan-doi-uu-dai-mung-xuan-giap-thin",
							ShortContent = "Gấp đôi ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini mừng Xuân Giáp Thìn. Khuyến mãi diễn ra từ 20.1 đến 2.2 với hoá đơn từ 599k và miễn phí giao hàng tận nơi",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#thong-tin-san-pham'>3. Thông tin sản phẩm Nhân Đôi Ưu Đãi</a></li>
                                                <li><a href='#dat-hang-hop-le'>4. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>5. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>6. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>7. Câu hỏi thường gặp</a></li>
                                            </ul>",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>
                                                1. Thời gian
                                            </h4>
                                            <p>
                                                Từ <strong>20.1</strong> đến hết ngày <strong>2.2</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua bất kì đơn hàng mô hình tại OmegaShop có giá trị từ 599.000 đ trở lên, bạn sẽ được tặng mô hình Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini. Cụ thể như sau:
                                            <p>
                                                – Đơn hàng từ <strong>599.000 đ</strong>, được tặng 1 mô hình nhựa 3D Chậu Hoa Nhỏ (trị giá 78k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ<strong>1.299.000 đ</strong> , được tặng 1 mô hình kim loại 3D Thiên Ngữ Hạc (trị giá 200k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ <strong>2.499.000 đ</strong> , được tặng 1 mô hình kim loại 3D Lân Phát Tài Mini (trị giá 270k)
                                            </p>
                                            <p style='color:red'>
                                                Lưu ý: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Mini là dạng Blind Box, vì vậy chúng tôi sẽ giao màu ngẫu nhiên.
                                            </p>
                                            <p>
                                                <i>Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini</i>
                                            </p>

                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                            </p>
                                            <h4 class='font-weight-bold' id='thong-tin-san-pham'>
                                                3. Thông tin sản phẩm NHÂN ĐÔI ƯU ĐÃI
                                            </h4>
                                            <p>
                                                Sản phẩm thuộc chương trình bao gồm: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Phát Tài Mini
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                4. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Giả sử đơn hàng gốc của quý khách sẽ mua là <strong>2.600.000 đ.</strong> Quý khách được hưởng 2 ưu đãi:
                                            </p>
                                            <p>
                                                1. Ưu đãi thuộc chương trình ưu đãi theo giá trị đơn hàng
                                            </p>
                                            <p>
                                                2. Nhân Đôi Ưu Đãi – Mừng Xuân Giáp Thìn (tặng 2 Chậu Hoa Nhỏ hoặc 2 Thiên Ngữ Hạc hoặc 1 Chậu Hoa Nhỏ + 1 Thiên Ngữ Hạc hoặc 1 Lân Mini)
                                            </p>
                                            <p>
                                                Quý khách vui lòng KHÔNG cho sản phẩm thuộc chương trình trên vào giỏ hàng , tại mục <strong>Lưu ý</strong> của bước<strong>Thanh Toán</strong> . Quý khách vui lòng ghi:Thiên Ngữ Hạc, Lân Mini…
                                            </p>
                                            <p>
                                                <strong>Lưu ý:</strong> Giá trị đơn hàng áp dụng Chương Trình Ưu Đãi sẽ bao gồm sản phẩm giảm giá
                                            </p>

                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>5. Đối tượng tham gia</h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua Fanpage Facebook và đặt hàng trên Website OmegaShop
                                            </p>
                                            <p>
                                                <i>
                                                    Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>6. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                7. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-10)
						},
						new Blog
						{

							Author = "Thanh Tú",
							Title = "Bài viết số 1",
							Thumbnail = "blog4.jpg",
							Slug = "bai-viet-so-1",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#dat-hang-hop-le'>3. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>4. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>5. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>6. Câu hỏi thường gặp</a></li>
                                            </ul>",
							ShortContent = "Mua kèm deal sốc hơn 130 sản phẩm HOT giảm giá đến 70% khi mua sắm với hóa đơn từ 299K . Áp dụng từ 7.1 ~ 15/1. FREESHIP với đơn từ 290K",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>1. Thời gian</h4>
                                            <p>
                                                Từ <strong>7.1</strong> đến hết ngày <strong>15.1</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua sắm với hóa đơn từ <strong>299k</strong>, quý khách sẽ
                                                được tham gia chương trình Mua Kèm Deal Sốc hơn 130 sản phẩm
                                                HOT với giá giảm đến 70%
                                            </p>
                                            <p>
                                                Danh sách sản phẩm thuộc chương trình
                                                <strong>Deal Sốc 2025</strong> quý khách xem tại đây:
                                                <a href='#'>https://omega.vn/collections/deal-soc-2024/</a>
                                            </p>
                                            <p class='font-weight-bold'>Cụ thể như sau:</p>
                                            <p>
                                                - Hóa Đơn (HD) từ <strong>299k</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 99k</span> chỉ với giá
                                                <strong>99k</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 299K</span> chỉ với giá
                                                <strong>299K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>699K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 499K</span> chỉ với giá
                                                <strong>499K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>899K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 699K</span> chỉ với giá
                                                <strong>699K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1099K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 899K</span> chỉ với giá
                                                <strong>899K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 1099K</span> chỉ với giá
                                                <strong>1099K</strong>
                                            </p>
                                            <p>
                                                <i>Áp dụng mua nhiều sản phẩm Deal Sốc trên cùng 1 hóa đơn</i>
                                            </p>
                                            <p><i>Không giới hạn số lần mua sắm</i></p>
                                            <p><i>Áp dụng FREESHIP đối với hóa đơn từ 290K</i></p>
                                            <p>
                                                <i>
                                                    Không áp dụng sản phẩm Deal Sốc đối với các chương trình
                                                    khuyến mãi khác. Quyền quyết định cuối cùng thuộc về
                                                    Omega
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                <strong>Ví dụ: </strong>Khách hàng mua 3 sản phẩm trong giỏ
                                                hàng (sản phẩm A = 400.000đ, sản phẩm B = 600.00đ, sản phẩm C
                                                = 500.000đ)
                                            </p>
                                            <p>
                                                Tổng hóa đơn: 1.500.000đ, áp voucher giảm 4% (60K) => Tổng
                                                thanh toán: 1.440.000 đ
                                            </p>
                                            <p>
                                                Quý khách hàng được tham gia chương trình
                                                <strong>Deal Sốc 2024</strong> linh hoạt như sau:
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 1: mua 4 sản phẩm trong danh sách Deal Sốc 99K,
                                                tổng đơn: 1.440.000 đ + (99.000 * 4) = 1.836.000đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 2: mua 2 sản phẩm trong danh sách Deal Sốc 299K và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + (299.000 đ * 2) + 99.000 đ = 2.137.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 3: mua 2 sản phẩm trong danh sách Deal Sốc 499k,
                                                tổng đơn: 1.440.000 đ + (499.000 đ * 2) = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 4: mua 1 sản phẩm trong danh sách Deal Sốc 699K và
                                                1 sản phẩm trong danh sách Deal Sốc 299K, tổng đơn: 1.440.000
                                                đ + 699.000 đ + 299.000 đ = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 5: mua 1 sản phẩm trong danh sách Deal Sốc 899k và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + 899.000 đ + 99.000 đ = 2.438.000 đ
                                            </p>
                                            <p>
                                                Quý khách có thể tự linh động kết hợp tùy vào giá trị hóa đơn,
                                                có thể mua 1 hoặc nhiều sản phẩm Deal Sốc.
                                            </p>
                                            <p>
                                                Trong trường hợp quý khách hàng gặp khó khăn hoặc chưa nắm rõ
                                                về chương trình. Vui lòng liên hệ Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>Đối với hóa đơn từ 290K, quý khách sẽ được FREESHIP</i>
                                            </p>
                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                                4. Đối tượng tham gia
                                            </h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua
                                                Fanpage Facebook và đặt hàng trên Website
                                                <a href='#'>https://omega.vn</a>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>5. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Không áp dụng đổi trả, bảo hành đối với sản phẩm tham gia
                                                    chương trình <strong>Deal Sốc 2024</strong>
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                6. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm AP cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-9)
						},
						new Blog
						{

							Author = "Anh Tú",
							Title = "Bài viết số 2",
							Thumbnail = "blog5.jpg",
							Slug = "bai-viet-so-2",
							ShortContent = "Giảm giá đến 70% toàn bộ mô hình lắp ráp 3D khi đặt hàng thành công tại website OmegaShop. FREESHIP với đơn từ 290K",
							ListContent = @"<ul class='menu pl-3 mt-3'>              
                                        <li><a href='#noi-dung'>1. Nội dung chương trình</a></li>
                                        <li><a href='#dat-hang-hop-le'>2. Cách thức đặt hàng hợp lệ</a></li>
                                        <li><a href='#doi-tuong-tham-gia'>3. Đối tượng tham gia</a></li>
                                        <li><a href='#luu-y'>4. Lưu ý</a></li>
                                        <li><a href='#cau-hoi'>5. Câu hỏi thường gặp</a></li>
                                    </ul>",
							Content = @"<div class='main-content'>
                                <h4 class='font-weight-bold' id='noi-dung'>
                                    1. Nội dung chương trình
                                </h4>
                                <p>
                                    Giảm giá đến <strong>70%</strong>, với tất cả sản phẩm  tại OmegaShop. Giá sản phẩm tại website là giá đã giảm.
                                </p>
                                <p>
                                    Xem toàn bộ mô hình tại đây:
                                    <a asp-controller='Product' asp-action='Index'>Sản phẩm</a>
                                </p>
                                <p>
                                    Áp dụng
                                    <strong>FREESHIP</strong> đối với hóa đơn từ<strong>290K</strong>

                                </p>
                                <p>
                                    <i>Không áp dụng đối với các chương trình khuyến mãi khác. Quyền quyết định cuối cùng thuộc về Art Puzzle</i>
                                </p>

                                <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                    2. Cách thức đặt hàng hợp lệ
                                </h4>
                                <p>
                                    Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                </p>

                                <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                    3. Đối tượng tham gia
                                </h4>
                                <p>
                                    Tất cả khách hàng mua tại showroom, mua online thông qua
                                    Fanpage Facebook và đặt hàng trên Website
                                    <a href='#'>Omega</a>
                                </p>
                                <h4 class='font-weight-bold' id='luu-y'>4. Lưu ý</h4>
                                <p>
                                    Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                    trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                    <strong>090 8427608</strong> (Mr. Duy)
                                </p>
                                <p>
                                    <i>
                                        Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                    </i>
                                </p>
                                <h4 class='font-weight-bold' id='cau-hoi'>
                                    5. Câu hỏi thường gặp
                                </h4>
                                <p>
                                    <strong>
                                        Q: Đơn gốc của mình trên 290k có được miễn ship
                                        không?
                                    </strong><br /><span>A: Có</span>
                                </p>
                                <p>
                                    <strong>
                                        Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                        gì?
                                    </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                </p>
                                <p>
                                    <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                </p>
                            </div>",

							CreatedAt = DateTime.Now.AddDays(-8)
						},
						new Blog
						{

							Author = "Hoàng Ánh",
							Title = "Bài viết số 3",
							Thumbnail = "blog6.jpg",
							Slug = "bai-viet-so-3",
							ShortContent = "Gấp đôi ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini mừng Xuân Giáp Thìn. Khuyến mãi diễn ra từ 20.1 đến 2.2 với hoá đơn từ 599k và miễn phí giao hàng tận nơi",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#thong-tin-san-pham'>3. Thông tin sản phẩm Nhân Đôi Ưu Đãi</a></li>
                                                <li><a href='#dat-hang-hop-le'>4. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>5. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>6. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>7. Câu hỏi thường gặp</a></li>
                                            </ul>",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>
                                                1. Thời gian
                                            </h4>
                                            <p>
                                                Từ <strong>20.1</strong> đến hết ngày <strong>2.2</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua bất kì đơn hàng mô hình tại OmegaShop có giá trị từ 599.000 đ trở lên, bạn sẽ được tặng mô hình Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini. Cụ thể như sau:
                                            <p>
                                                – Đơn hàng từ <strong>599.000 đ</strong>, được tặng 1 mô hình nhựa 3D Chậu Hoa Nhỏ (trị giá 78k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ<strong>1.299.000 đ</strong> , được tặng 1 mô hình kim loại 3D Thiên Ngữ Hạc (trị giá 200k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ <strong>2.499.000 đ</strong> , được tặng 1 mô hình kim loại 3D Lân Phát Tài Mini (trị giá 270k)
                                            </p>
                                            <p style='color:red'>
                                                Lưu ý: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Mini là dạng Blind Box, vì vậy chúng tôi sẽ giao màu ngẫu nhiên.
                                            </p>
                                            <p>
                                                <i>Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini</i>
                                            </p>

                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                            </p>
                                            <h4 class='font-weight-bold' id='thong-tin-san-pham'>
                                                3. Thông tin sản phẩm NHÂN ĐÔI ƯU ĐÃI
                                            </h4>
                                            <p>
                                                Sản phẩm thuộc chương trình bao gồm: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Phát Tài Mini
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                4. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Giả sử đơn hàng gốc của quý khách sẽ mua là <strong>2.600.000 đ.</strong> Quý khách được hưởng 2 ưu đãi:
                                            </p>
                                            <p>
                                                1. Ưu đãi thuộc chương trình ưu đãi theo giá trị đơn hàng
                                            </p>
                                            <p>
                                                2. Nhân Đôi Ưu Đãi – Mừng Xuân Giáp Thìn (tặng 2 Chậu Hoa Nhỏ hoặc 2 Thiên Ngữ Hạc hoặc 1 Chậu Hoa Nhỏ + 1 Thiên Ngữ Hạc hoặc 1 Lân Mini)
                                            </p>
                                            <p>
                                                Quý khách vui lòng KHÔNG cho sản phẩm thuộc chương trình trên vào giỏ hàng , tại mục <strong>Lưu ý</strong> của bước<strong>Thanh Toán</strong> . Quý khách vui lòng ghi:Thiên Ngữ Hạc, Lân Mini…
                                            </p>
                                            <p>
                                                <strong>Lưu ý:</strong> Giá trị đơn hàng áp dụng Chương Trình Ưu Đãi sẽ bao gồm sản phẩm giảm giá
                                            </p>

                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>5. Đối tượng tham gia</h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua Fanpage Facebook và đặt hàng trên Website OmegaShop
                                            </p>
                                            <p>
                                                <i>
                                                    Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>6. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                7. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-7)
						},
						new Blog
						{

							Author = "Ri Đỗ",
							Title = "Bài viết số 4",
							Thumbnail = "blog7.jpg",
							Slug = "bai-viet-so-4",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#dat-hang-hop-le'>3. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>4. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>5. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>6. Câu hỏi thường gặp</a></li>
                                            </ul>",
							ShortContent = "Mua kèm deal sốc hơn 130 sản phẩm HOT giảm giá đến 70% khi mua sắm với hóa đơn từ 299K . Áp dụng từ 7.1 ~ 15/1. FREESHIP với đơn từ 290K",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>1. Thời gian</h4>
                                            <p>
                                                Từ <strong>7.1</strong> đến hết ngày <strong>15.1</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua sắm với hóa đơn từ <strong>299k</strong>, quý khách sẽ
                                                được tham gia chương trình Mua Kèm Deal Sốc hơn 130 sản phẩm
                                                HOT với giá giảm đến 70%
                                            </p>
                                            <p>
                                                Danh sách sản phẩm thuộc chương trình
                                                <strong>Deal Sốc 2025</strong> quý khách xem tại đây:
                                                <a href='#'>https://omega.vn/collections/deal-soc-2024/</a>
                                            </p>
                                            <p class='font-weight-bold'>Cụ thể như sau:</p>
                                            <p>
                                                - Hóa Đơn (HD) từ <strong>299k</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 99k</span> chỉ với giá
                                                <strong>99k</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 299K</span> chỉ với giá
                                                <strong>299K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>699K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 499K</span> chỉ với giá
                                                <strong>499K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>899K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 699K</span> chỉ với giá
                                                <strong>699K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1099K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 899K</span> chỉ với giá
                                                <strong>899K</strong>
                                            </p>
                                            <p>
                                                - HĐ từ <strong>1499K</strong>: Mua 1 sản phẩm có tag
                                                <span class='text-primary'>Deal Sốc 1099K</span> chỉ với giá
                                                <strong>1099K</strong>
                                            </p>
                                            <p>
                                                <i>Áp dụng mua nhiều sản phẩm Deal Sốc trên cùng 1 hóa đơn</i>
                                            </p>
                                            <p><i>Không giới hạn số lần mua sắm</i></p>
                                            <p><i>Áp dụng FREESHIP đối với hóa đơn từ 290K</i></p>
                                            <p>
                                                <i>
                                                    Không áp dụng sản phẩm Deal Sốc đối với các chương trình
                                                    khuyến mãi khác. Quyền quyết định cuối cùng thuộc về
                                                    Omega
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                <strong>Ví dụ: </strong>Khách hàng mua 3 sản phẩm trong giỏ
                                                hàng (sản phẩm A = 400.000đ, sản phẩm B = 600.00đ, sản phẩm C
                                                = 500.000đ)
                                            </p>
                                            <p>
                                                Tổng hóa đơn: 1.500.000đ, áp voucher giảm 4% (60K) => Tổng
                                                thanh toán: 1.440.000 đ
                                            </p>
                                            <p>
                                                Quý khách hàng được tham gia chương trình
                                                <strong>Deal Sốc 2024</strong> linh hoạt như sau:
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 1: mua 4 sản phẩm trong danh sách Deal Sốc 99K,
                                                tổng đơn: 1.440.000 đ + (99.000 * 4) = 1.836.000đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 2: mua 2 sản phẩm trong danh sách Deal Sốc 299K và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + (299.000 đ * 2) + 99.000 đ = 2.137.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 3: mua 2 sản phẩm trong danh sách Deal Sốc 499k,
                                                tổng đơn: 1.440.000 đ + (499.000 đ * 2) = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 4: mua 1 sản phẩm trong danh sách Deal Sốc 699K và
                                                1 sản phẩm trong danh sách Deal Sốc 299K, tổng đơn: 1.440.000
                                                đ + 699.000 đ + 299.000 đ = 2.438.000 đ
                                            </p>
                                            <p style='color: #16a085'>
                                                - Lựa chọn 5: mua 1 sản phẩm trong danh sách Deal Sốc 899k và
                                                1 sản phẩm trong danh sách Deal Sốc 99K, tổng đơn: 1.440.000 đ
                                                + 899.000 đ + 99.000 đ = 2.438.000 đ
                                            </p>
                                            <p>
                                                Quý khách có thể tự linh động kết hợp tùy vào giá trị hóa đơn,
                                                có thể mua 1 hoặc nhiều sản phẩm Deal Sốc.
                                            </p>
                                            <p>
                                                Trong trường hợp quý khách hàng gặp khó khăn hoặc chưa nắm rõ
                                                về chương trình. Vui lòng liên hệ Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>Đối với hóa đơn từ 290K, quý khách sẽ được FREESHIP</i>
                                            </p>
                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                                4. Đối tượng tham gia
                                            </h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua
                                                Fanpage Facebook và đặt hàng trên Website
                                                <a href='#'>https://omega.vn</a>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>5. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Không áp dụng đổi trả, bảo hành đối với sản phẩm tham gia
                                                    chương trình <strong>Deal Sốc 2024</strong>
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                6. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm AP cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-6)
						},
						new Blog
						{

							Author = "Tú Moow",
							Title = "Bài viết số 5",
							Thumbnail = "blog8.jpg",
							Slug = "bai-viet-so-5",
							ShortContent = "Giảm giá đến 70% toàn bộ mô hình lắp ráp 3D khi đặt hàng thành công tại website OmegaShop. FREESHIP với đơn từ 290K",
							ListContent = @"<ul class='menu pl-3 mt-3'>              
                                        <li><a href='#noi-dung'>1. Nội dung chương trình</a></li>
                                        <li><a href='#dat-hang-hop-le'>2. Cách thức đặt hàng hợp lệ</a></li>
                                        <li><a href='#doi-tuong-tham-gia'>3. Đối tượng tham gia</a></li>
                                        <li><a href='#luu-y'>4. Lưu ý</a></li>
                                        <li><a href='#cau-hoi'>5. Câu hỏi thường gặp</a></li>
                                    </ul>",
							Content = @"<div class='main-content'>
                                <h4 class='font-weight-bold' id='noi-dung'>
                                    1. Nội dung chương trình
                                </h4>
                                <p>
                                    Giảm giá đến <strong>70%</strong>, với tất cả sản phẩm  tại OmegaShop. Giá sản phẩm tại website là giá đã giảm.
                                </p>
                                <p>
                                    Xem toàn bộ mô hình tại đây:
                                    <a asp-controller='Product' asp-action='Index'>Sản phẩm</a>
                                </p>
                                <p>
                                    Áp dụng
                                    <strong>FREESHIP</strong> đối với hóa đơn từ<strong>290K</strong>

                                </p>
                                <p>
                                    <i>Không áp dụng đối với các chương trình khuyến mãi khác. Quyền quyết định cuối cùng thuộc về Art Puzzle</i>
                                </p>

                                <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                    2. Cách thức đặt hàng hợp lệ
                                </h4>
                                <p>
                                    Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                </p>

                                <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>
                                    3. Đối tượng tham gia
                                </h4>
                                <p>
                                    Tất cả khách hàng mua tại showroom, mua online thông qua
                                    Fanpage Facebook và đặt hàng trên Website
                                    <a href='#'>Omega</a>
                                </p>
                                <h4 class='font-weight-bold' id='luu-y'>4. Lưu ý</h4>
                                <p>
                                    Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                    trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                    <strong>090 8427608</strong> (Mr. Duy)
                                </p>
                                <p>
                                    <i>
                                        Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                    </i>
                                </p>
                                <h4 class='font-weight-bold' id='cau-hoi'>
                                    5. Câu hỏi thường gặp
                                </h4>
                                <p>
                                    <strong>
                                        Q: Đơn gốc của mình trên 290k có được miễn ship
                                        không?
                                    </strong><br /><span>A: Có</span>
                                </p>
                                <p>
                                    <strong>
                                        Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                        gì?
                                    </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                </p>
                                <p>
                                    <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                </p>
                            </div>",

							CreatedAt = DateTime.Now.AddDays(-5)
						},
						new Blog
						{

							Author = "Nam Lor",
							Title = "Bài viết số 6",
							Thumbnail = "blog9.jpg",
							Slug = "bai-viet-so-7",
							ShortContent = "Gấp đôi ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini mừng Xuân Giáp Thìn. Khuyến mãi diễn ra từ 20.1 đến 2.2 với hoá đơn từ 599k và miễn phí giao hàng tận nơi",
							ListContent = @"<ul class='menu pl-3 mt-3'>
                                                <li><a href='#thoi-gian'>1. Thời gian</a></li>
                                                <li><a href='#noi-dung'>2. Nội dung chương trình</a></li>
                                                <li><a href='#thong-tin-san-pham'>3. Thông tin sản phẩm Nhân Đôi Ưu Đãi</a></li>
                                                <li><a href='#dat-hang-hop-le'>4. Cách thức đặt hàng hợp lệ</a></li>
                                                <li><a href='#doi-tuong-tham-gia'>5. Đối tượng tham gia</a></li>
                                                <li><a href='#luu-y'>6. Lưu ý</a></li>
                                                <li><a href='#cau-hoi'>7. Câu hỏi thường gặp</a></li>
                                            </ul>",
							Content = @"<div class='main-content'>
                                            <h4 class='font-weight-bold' id='thoi-gian'>
                                                1. Thời gian
                                            </h4>
                                            <p>
                                                Từ <strong>20.1</strong> đến hết ngày <strong>2.2</strong>
                                            </p>
                                            <h4 class='font-weight-bold' id='noi-dung'>
                                                2. Nội dung chương trình
                                            </h4>
                                            <p>
                                                Khi mua bất kì đơn hàng mô hình tại OmegaShop có giá trị từ 599.000 đ trở lên, bạn sẽ được tặng mô hình Chậu Hoa Nhỏ, Thiên Ngữ Hạc hoặc Lân Phát Tài Mini. Cụ thể như sau:
                                            <p>
                                                – Đơn hàng từ <strong>599.000 đ</strong>, được tặng 1 mô hình nhựa 3D Chậu Hoa Nhỏ (trị giá 78k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ<strong>1.299.000 đ</strong> , được tặng 1 mô hình kim loại 3D Thiên Ngữ Hạc (trị giá 200k)
                                            </p>
                                            <p>
                                                – Đơn hàng từ <strong>2.499.000 đ</strong> , được tặng 1 mô hình kim loại 3D Lân Phát Tài Mini (trị giá 270k)
                                            </p>
                                            <p style='color:red'>
                                                Lưu ý: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Mini là dạng Blind Box, vì vậy chúng tôi sẽ giao màu ngẫu nhiên.
                                            </p>
                                            <p>
                                                <i>Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini</i>
                                            </p>

                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                3. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Quý khách hàng là thành viên tại OmegaShop, đặt hàng thành công tại website đối với 3 hình thức thanh toán: COD, MOMO và chuyển khoản ngân hàng
                                            </p>
                                            <h4 class='font-weight-bold' id='thong-tin-san-pham'>
                                                3. Thông tin sản phẩm NHÂN ĐÔI ƯU ĐÃI
                                            </h4>
                                            <p>
                                                Sản phẩm thuộc chương trình bao gồm: Chậu Hoa Nhỏ, Thiên Ngữ Hạc và Lân Phát Tài Mini
                                            </p>
                                            <h4 class='font-weight-bold' id='dat-hang-hop-le'>
                                                4. Cách thức đặt hàng hợp lệ
                                            </h4>
                                            <p>
                                                Giả sử đơn hàng gốc của quý khách sẽ mua là <strong>2.600.000 đ.</strong> Quý khách được hưởng 2 ưu đãi:
                                            </p>
                                            <p>
                                                1. Ưu đãi thuộc chương trình ưu đãi theo giá trị đơn hàng
                                            </p>
                                            <p>
                                                2. Nhân Đôi Ưu Đãi – Mừng Xuân Giáp Thìn (tặng 2 Chậu Hoa Nhỏ hoặc 2 Thiên Ngữ Hạc hoặc 1 Chậu Hoa Nhỏ + 1 Thiên Ngữ Hạc hoặc 1 Lân Mini)
                                            </p>
                                            <p>
                                                Quý khách vui lòng KHÔNG cho sản phẩm thuộc chương trình trên vào giỏ hàng , tại mục <strong>Lưu ý</strong> của bước<strong>Thanh Toán</strong> . Quý khách vui lòng ghi:Thiên Ngữ Hạc, Lân Mini…
                                            </p>
                                            <p>
                                                <strong>Lưu ý:</strong> Giá trị đơn hàng áp dụng Chương Trình Ưu Đãi sẽ bao gồm sản phẩm giảm giá
                                            </p>

                                            <h4 class='font-weight-bold' id='doi-tuong-tham-gia'>5. Đối tượng tham gia</h4>
                                            <p>
                                                Tất cả khách hàng mua tại showroom, mua online thông qua Fanpage Facebook và đặt hàng trên Website OmegaShop
                                            </p>
                                            <p>
                                                <i>
                                                    Mỗi khách hàng chỉ được hưởng ưu đãi tặng Chậu Hoa Nhỏ, Thiên Ngữ Hạc, Lân Mini tối đa 2 sản phẩm. Ví dụ: 2x Thiên Ngữ Hạc HOẶC 2x Lân Mini HOẶC 1 Thiên Ngữ Hạc và 1 Lân Mini
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='luu-y'>6. Lưu ý</h4>
                                            <p>
                                                Quý khách hàng vui lòng liên hệ nhân viên để kiểm tra tình
                                                trạng còn hàng của các sản phẩm thông qua qua Hotline:
                                                <strong>090 8427608</strong> (Mr. Duy)
                                            </p>
                                            <p>
                                                <i>
                                                    Quý khách hàng vui lòng quay phim khi unbox sản phẩm, chúng tôi sẽ không giải quyết bất kỳ khiếu nại nào nếu không có video
                                                </i>
                                            </p>
                                            <h4 class='font-weight-bold' id='cau-hoi'>
                                                7. Câu hỏi thường gặp
                                            </h4>
                                            <p>
                                                <strong>
                                                    Q: Đơn gốc của mình trên 290k có được miễn ship
                                                    không?
                                                </strong><br /><span>A: Có</span>
                                            </p>
                                            <p>
                                                <strong>
                                                    Q: Mình muốn tư vấn trực tiếp, hotline của bạn là
                                                    gì?
                                                </strong><br /><span>A: Hotline: <strong>090 8427608</strong> (Mr. Duy)</span>
                                            </p>
                                            <p>
                                                <strong>Q: Chương trình có tích điểm cho mình không?</strong><br /><span>A: Có</span>
                                            </p>
                                        </div>",
							CreatedAt = DateTime.Now.AddDays(-4)
						},
						new Blog
						{

							Author = "Phát bé",
							Title = "Dịch vụ vận chuyển",
							Thumbnail = "blog10.jpg",
							Slug = "dich-vu-van-chuyen",
							ListContent = "",
							ShortContent = "",
							Content = @"<!-- Breadcrumb Start -->
                                <div class=""breadcrumb-wrap"">
                                    <div class=""container"">
                                        <ul class=""breadcrumb"">
                                            <li class=""breadcrumb-item""><a asp-controller=""Home"" asp-action=""Index"">Trang chủ</a></li>
                                            <li class=""breadcrumb-item active"">Bài viết</li>
                                            <li class=""breadcrumb-item active text-uppercase"">
                                                Mua kèm deal sốc - giảm đến 70%
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- Breadcrumb End -->
                                <!-- Post detail Start -->
                                <div class=""post-detail mt-5"">
                                    <div class=""container"">
                                        <div class=""row mt-3"">
                                            <div class=""col-lg-9"">
                                                <div class=""post-heading"">
                                                    <h5 class=""title text-uppercase font-weight-bold"">
                                                        Giới Thiệu Dịch Vụ ""Giao Hàng Toàn Quốc"" Trên Trang Web Bán Hàng Của Omega
                                                    </h5>
                                                    <div class=""meta d-flex"">
                                                        <p class=""author"">Bởi: Huỳnh Anh Tú</p>
                                                        <p class=""date ml-5"">10 tháng 01, 2025</p>
                                                    </div>
                                                </div>
                                                <div class=""post-content"">
                                                    <div class=""post-img p-2"">
                                                        <img class=""d-block w-100""
                                                             src=""~/img/deal_soc_banner.jpg""
                                                             alt="""" />
                                                    </div>

                                                    <div class=""main-content"">
                                                        <p>
                                                            Một trong những yếu tố quan trọng nhất khi mua sắm trực tuyến chính là dịch vụ giao hàng. Dịch vụ giao hàng chất lượng không chỉ giúp khách hàng nhận được sản phẩm một cách nhanh chóng và an toàn, mà còn tạo nên sự tin tưởng và hài lòng. Trang web bán hàng của chúng tôi tự hào giới thiệu dịch vụ ""Giao Hàng"" với những ưu điểm vượt trội.
                                                        </p>
                                                        <h6>
                                                            Nhanh Chóng và Hiệu Quả
                                                        </h6>
                                                        <p>
                                                            Chúng tôi hiểu rằng thời gian của khách hàng là vàng bạc, vì vậy, dịch vụ giao hàng của chúng tôi được thiết kế để đảm bảo tốc độ và hiệu quả cao nhất:
                                                        </p>
                                                        <ul>
                                                            <li>
                                                                <p>
                                                                    Giao hàng trong ngày: Đối với các đơn hàng trong phạm vi nội thành, chúng tôi cam kết giao hàng trong ngày, giúp bạn nhận sản phẩm ngay khi cần.
                                                                    v
                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Giao hàng nhanh: Đối với các đơn hàng liên tỉnh hoặc quốc tế, chúng tôi hợp tác với các đơn vị vận chuyển uy tín để đảm bảo thời gian giao hàng nhanh chóng và đúng hẹn.

                                                                </p>
                                                            </li>
                                                        </ul>
                                                        <h6>
                                                            An Toàn và Đáng Tin Cậy
                                                        </h6>
                                                        <p>
                                                            Sự an toàn của sản phẩm trong quá trình vận chuyển là ưu tiên hàng đầu của chúng tôi:
                                                        </p>
                                                        <ul>
                                                            <li>
                                                                <p>
                                                                    Đóng gói chắc chắn: Mọi sản phẩm đều được đóng gói cẩn thận để tránh hư hỏng trong quá trình vận chuyển.

                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Theo dõi đơn hàng: Chúng tôi cung cấp dịch vụ theo dõi đơn hàng trực tuyến, giúp bạn dễ dàng kiểm tra trạng thái đơn hàng mọi lúc mọi nơi.

                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Bảo hiểm hàng hóa: Trong trường hợp xảy ra sự cố, chúng tôi cam kết bồi thường thỏa đáng cho khách hàng, đảm bảo quyền lợi của bạn luôn được bảo vệ.

                                                                </p>
                                                            </li>
                                                        </ul>
                                                        <h6>
                                                            Linh Hoạt và Tiện Lợi
                                                        </h6>
                                                        <p>
                                                            Dịch vụ giao hàng của chúng tôi không chỉ nhanh chóng và an toàn mà còn rất linh hoạt và tiện lợi:
                                                        </p>
                                                        <ul>
                                                            <li>
                                                                <p>
                                                                    Lựa chọn thời gian giao hàng: Bạn có thể chọn thời gian giao hàng phù hợp với lịch trình của mình, từ buổi sáng, buổi chiều cho đến buổi tối.

                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Giao hàng tận nơi: Chúng tôi giao hàng đến tận nơi bạn yêu cầu, dù đó là nhà riêng, văn phòng hay bất kỳ địa điểm nào khác.

                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Dịch vụ giao hàng miễn phí: Chúng tôi cung cấp dịch vụ giao hàng miễn phí cho các đơn hàng đạt giá trị nhất định, giúp bạn tiết kiệm chi phí.

                                                                </p>
                                                            </li>
                                                        </ul>
                                                        <h6>
                                                            Chăm Sóc Khách Hàng Tận Tình
                                                        </h6>
                                                        <p>
                                                            Đội ngũ chăm sóc khách hàng của chúng tôi luôn sẵn sàng hỗ trợ bạn trong mọi tình huống liên quan đến dịch vụ giao hàng:

                                                        </p>
                                                        <ul>
                                                            <li>
                                                                <p>
                                                                    Tư vấn và hỗ trợ 24/7: Bạn có thể liên hệ với chúng tôi bất kỳ lúc nào để được giải đáp thắc mắc và hỗ trợ kịp thời.

                                                                </p>
                                                            </li>
                                                            <li>
                                                                <p>
                                                                    Giải quyết khiếu nại nhanh chóng: Nếu có bất kỳ vấn đề nào xảy ra với đơn hàng của bạn, chúng tôi cam kết giải quyết khiếu nại một cách nhanh chóng và công bằng.

                                                                </p>
                                                            </li>
                                                        </ul>
                                                        <p>
                                                            Với dịch vụ ""Giao Hàng"" của chúng tôi, bạn có thể hoàn toàn yên tâm về sự an toàn, nhanh chóng và tiện lợi trong mỗi đơn hàng. Hãy trải nghiệm ngay và tận hưởng dịch vụ chất lượng hàng đầu mà chúng tôi mang lại!

                                                        </p>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <!-- Post detail End -->",
							CreatedAt = DateTime.Now.AddDays(-3)
						},
						new Blog
						{

							Author = "Anh Ánh",
							Title = "Đổi trả hàng nhanh",
							Thumbnail = "blog12.jpg",
							Slug = "doi-tra-hang-nhanh",
							ListContent = "",
							ShortContent = "",
							Content = @"<!-- Breadcrumb Start -->
<div class=""breadcrumb-wrap"">
    <div class=""container"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a asp-controller=""Home"" asp-action=""Index"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Bài viết</li>
            <li class=""breadcrumb-item active text-uppercase"">
                Mua kèm deal sốc - giảm đến 70%
            </li>
        </ul>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Post detail Start -->
<div class=""post-detail mt-5"">
    <div class=""container"">
        <div class=""row mt-3"">
            <div class=""col-lg-9"">
                <div class=""post-heading"">
                    <h5 class=""title text-uppercase font-weight-bold"">
                        Giới Thiệu Dịch Vụ ""Đổi Trả Hàng Nhanh"" Trên Trang Web Bán Hàng Của Omega
                    </h5>
                    <div class=""meta d-flex"">
                        <p class=""author"">Bởi: Huỳnh Anh Tú</p>
                        <p class=""date ml-5"">10 tháng 01, 2025</p>
                    </div>
                </div>
                <div class=""post-content"">
                    <div class=""post-img p-2"">
                        <img class=""d-block w-100""
                             src=""~/img/deal_soc_banner.jpg""
                             alt="""" />
                    </div>

                    <div class=""main-content"">
                        <p>
                            Một trong những yếu tố quan trọng nhất khi mua sắm trực tuyến chính là dịch vụ giao hàng. Dịch vụ giao hàng chất lượng không chỉ giúp khách hàng nhận được sản phẩm một cách nhanh chóng và an toàn, mà còn tạo nên sự tin tưởng và hài lòng. Trang web bán hàng của chúng tôi tự hào giới thiệu dịch vụ ""Giao Hàng"" với những ưu điểm vượt trội.
                        </p>
                        <h6>
                            Nhanh Chóng và Hiệu Quả
                        </h6>
                        <p>
                            Chúng tôi hiểu rằng thời gian của khách hàng là vàng bạc, vì vậy, dịch vụ giao hàng của chúng tôi được thiết kế để đảm bảo tốc độ và hiệu quả cao nhất:
                        </p>
                        <ul>
                            <li>
                                <p>
                                    Giao hàng trong ngày: Đối với các đơn hàng trong phạm vi nội thành, chúng tôi cam kết giao hàng trong ngày, giúp bạn nhận sản phẩm ngay khi cần.
                                    v
                                </p>
                            </li>
                            <li>
                                <p>
                                    Giao hàng nhanh: Đối với các đơn hàng liên tỉnh hoặc quốc tế, chúng tôi hợp tác với các đơn vị vận chuyển uy tín để đảm bảo thời gian giao hàng nhanh chóng và đúng hẹn.

                                </p>
                            </li>
                        </ul>
                        <h6>
                            An Toàn và Đáng Tin Cậy
                        </h6>
                        <p>
                            Sự an toàn của sản phẩm trong quá trình vận chuyển là ưu tiên hàng đầu của chúng tôi:
                        </p>
                        <ul>
                            <li>
                                <p>
                                    Đóng gói chắc chắn: Mọi sản phẩm đều được đóng gói cẩn thận để tránh hư hỏng trong quá trình vận chuyển.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Theo dõi đơn hàng: Chúng tôi cung cấp dịch vụ theo dõi đơn hàng trực tuyến, giúp bạn dễ dàng kiểm tra trạng thái đơn hàng mọi lúc mọi nơi.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Bảo hiểm hàng hóa: Trong trường hợp xảy ra sự cố, chúng tôi cam kết bồi thường thỏa đáng cho khách hàng, đảm bảo quyền lợi của bạn luôn được bảo vệ.

                                </p>
                            </li>
                        </ul>
                        <h6>
                            Linh Hoạt và Tiện Lợi
                        </h6>
                        <p>
                            Dịch vụ giao hàng của chúng tôi không chỉ nhanh chóng và an toàn mà còn rất linh hoạt và tiện lợi:
                        </p>
                        <ul>
                            <li>
                                <p>
                                    Lựa chọn thời gian giao hàng: Bạn có thể chọn thời gian giao hàng phù hợp với lịch trình của mình, từ buổi sáng, buổi chiều cho đến buổi tối.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Giao hàng tận nơi: Chúng tôi giao hàng đến tận nơi bạn yêu cầu, dù đó là nhà riêng, văn phòng hay bất kỳ địa điểm nào khác.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Dịch vụ giao hàng miễn phí: Chúng tôi cung cấp dịch vụ giao hàng miễn phí cho các đơn hàng đạt giá trị nhất định, giúp bạn tiết kiệm chi phí.

                                </p>
                            </li>
                        </ul>
                        <h6>
                            Chăm Sóc Khách Hàng Tận Tình
                        </h6>
                        <p>
                            Đội ngũ chăm sóc khách hàng của chúng tôi luôn sẵn sàng hỗ trợ bạn trong mọi tình huống liên quan đến dịch vụ giao hàng:

                        </p>
                        <ul>
                            <li>
                                <p>
                                    Tư vấn và hỗ trợ 24/7: Bạn có thể liên hệ với chúng tôi bất kỳ lúc nào để được giải đáp thắc mắc và hỗ trợ kịp thời.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Giải quyết khiếu nại nhanh chóng: Nếu có bất kỳ vấn đề nào xảy ra với đơn hàng của bạn, chúng tôi cam kết giải quyết khiếu nại một cách nhanh chóng và công bằng.

                                </p>
                            </li>
                        </ul>
                        <p>
                            Với dịch vụ ""Giao Hàng"" của chúng tôi, bạn có thể hoàn toàn yên tâm về sự an toàn, nhanh chóng và tiện lợi trong mỗi đơn hàng. Hãy trải nghiệm ngay và tận hưởng dịch vụ chất lượng hàng đầu mà chúng tôi mang lại!

                        </p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
<!-- Post detail End -->",
							CreatedAt = DateTime.Now.AddDays(-3)
						},
						new Blog
						{

							Author = "Anh Ánh",
							Title = "Phương thức thanh toán",
							Thumbnail = "blog2.jpg",
							Slug = "phuong-thuc-thanh-toan",
							ListContent = "",
							ShortContent = "",
							Content = @"<!-- Breadcrumb Start -->
<div class=""breadcrumb-wrap"">
    <div class=""container"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a asp-controller=""Home"" asp-action=""Index"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Bài viết</li>
            <li class=""breadcrumb-item active text-uppercase"">
                Mua kèm deal sốc - giảm đến 70%
            </li>
        </ul>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Post detail Start -->
<div class=""post-detail mt-5"">
    <div class=""container"">
        <div class=""row mt-3"">
            <div class=""col-lg-9"">
                <div class=""post-heading"">
                    <h5 class=""title text-uppercase font-weight-bold"">
                        Giới Thiệu Dịch Vụ ""Thanh Toán An Toàn"" Trên Website Của Omega
                    </h5>
                    <div class=""meta d-flex"">
                        <p class=""author"">Bởi: Huỳnh Anh Tú</p>
                        <p class=""date ml-5"">10 tháng 01, 2025</p>
                    </div>
                </div>
                <div class=""post-content"">
                    <div class=""post-img p-2"">
                        <img class=""d-block w-100""
                             src=""~/img/deal_soc_banner.jpg""
                             alt="""" />
                    </div>

                    <div class=""main-content"">
                        <p>Trong bối cảnh thương mại điện tử ngày càng phát triển, việc cung cấp một dịch vụ thanh toán an toàn và tiện lợi là điều vô cùng quan trọng. Trang web bán hàng của chúng tôi tự hào giới thiệu dịch vụ ""Thanh Toán An Toàn,"" mang đến cho khách hàng những trải nghiệm mua sắm trực tuyến bảo mật và dễ dàng.</p>

                        <h6>Thanh Toán Trực Tiếp</h6>
                        <p>Với dịch vụ thanh toán trực tiếp, khách hàng có thể thực hiện giao dịch một cách nhanh chóng và tiện lợi. Dưới đây là những điểm nổi bật của dịch vụ này:</p>

                        <ul>
                            <li><p>Bảo mật cao: Thông tin tài chính của bạn được mã hóa và bảo vệ bởi các tiêu chuẩn bảo mật hàng đầu, đảm bảo mọi giao dịch được thực hiện an toàn.</p></li>
                            <li><p>Tiện lợi: Chỉ cần vài cú nhấp chuột, bạn có thể hoàn tất thanh toán mà không cần phải rời khỏi trang web. Điều này giúp tiết kiệm thời gian và công sức cho khách hàng.</p></li>
                            <li><p>Đa dạng phương thức thanh toán: Hỗ trợ nhiều loại thẻ tín dụng và thẻ ghi nợ, giúp khách hàng dễ dàng lựa chọn phương thức thanh toán phù hợp nhất.</p></li>
                        </ul>
                        <h6>Thanh Toán Qua MoMo</h6>
                        <p>Bên cạnh thanh toán trực tiếp, trang web của chúng tôi còn tích hợp dịch vụ thanh toán qua MoMo, một trong những ví điện tử phổ biến nhất hiện nay. Dưới đây là những lợi ích khi sử dụng MoMo:</p>
                        <ul>
                            <li>
                                <p>
                                    An toàn và bảo mật: MoMo sử dụng công nghệ mã hóa tiên tiến, giúp bảo vệ thông tin tài chính của bạn khỏi các mối đe dọa.
                                </p>
                            </li>
                            <li>
                                <p>
                                    Tiện ích và nhanh chóng: Chỉ với vài thao tác đơn giản trên điện thoại di động, bạn có thể thanh toán một cách nhanh chóng và tiện lợi.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Ưu đãi hấp dẫn: MoMo thường xuyên có các chương trình khuyến mãi và ưu đãi hấp dẫn dành cho người dùng, giúp bạn tiết kiệm chi phí khi mua sắm trực tuyến.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Đa dạng dịch vụ: Không chỉ thanh toán mua sắm, bạn còn có thể sử dụng MoMo để thanh toán các dịch vụ khác như điện, nước, internet, và nhiều hơn nữa.

                                </p>
                            </li>

                        </ul>
                        <h6>Tại Sao Nên Chọn Dịch Vụ ""Thanh Toán An Toàn"" Của Chúng Tôi?</h6>
                        <ul>
                            <li>
                                <p>
                                    Đảm bảo bảo mật: Với tiêu chuẩn bảo mật cao, chúng tôi cam kết bảo vệ thông tin cá nhân và tài chính của khách hàng.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Hỗ trợ khách hàng 24/7: Đội ngũ chăm sóc khách hàng của chúng tôi luôn sẵn sàng hỗ trợ bạn bất kỳ lúc nào bạn cần.

                                </p>
                            </li>
                            <li>
                                <p>
                                    Tiện lợi và nhanh chóng: Dịch vụ ""Thanh Toán An Toàn"" giúp bạn thanh toán một cách dễ dàng và nhanh chóng, mang lại trải nghiệm mua sắm trực tuyến tuyệt vời.

                                </p>
                            </li>
                        </ul>
                        <p>Hãy trải nghiệm ngay dịch vụ ""Thanh Toán An Toàn"" của chúng tôi để tận hưởng sự tiện lợi và bảo mật trong mỗi giao dịch. Chúng tôi luôn đồng hành cùng bạn trên mỗi chặng đường mua sắm trực tuyến!</p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
<!-- Post detail End -->",
							CreatedAt = DateTime.Now.AddDays(-3)
						},
						new Blog
						{
							Author = "Atus",
							Title = "Hỗ trợ",
							Thumbnail = "blog3.jpg",
							Slug = "ho-tro",
							ShortContent = "",
							ListContent = "",
							Content = @"<!-- Breadcrumb Start -->
                            <div class=""breadcrumb-wrap"">
                                <div class=""container"">
                                    <ul class=""breadcrumb"">
                                        <li class=""breadcrumb-item""><a asp-controller=""Home"" asp-action=""Index"">Trang chủ</a></li>
                                        <li class=""breadcrumb-item active"">Bài viết</li>
                                        <li class=""breadcrumb-item active text-uppercase"">
                                            Mua kèm deal sốc - giảm đến 70%
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- Breadcrumb End -->
                            <!-- Post detail Start -->
                            <div class=""post-detail mt-5"">
                                <div class=""container"">
                                    <div class=""row mt-3"">
                                        <div class=""col-lg-9"">
                                            <div class=""post-heading"">
                                                <h5 class=""title text-uppercase font-weight-bold"">
                                                    Giới Thiệu Dịch Vụ ""Hỗ Trợ 24/7"" Trên Trang Web Bán Hàng Của Omega
                                                </h5>
                                                <div class=""meta d-flex"">
                                                    <p class=""author"">Bởi: Huỳnh Anh Tú</p>
                                                    <p class=""date ml-5"">10 tháng 01, 2025</p>
                                                </div>
                                            </div>
                                            <div class=""post-content"">
                                                <div class=""post-img p-2"">
                                                    <img class=""d-block w-100""
                                                         src=""~/img/deal_soc_banner.jpg""
                                                         alt="""" />
                                                </div>

                                                <div class=""main-content"">
                                                    <p>
                                                        Một trong những yếu tố quan trọng nhất khi mua sắm trực tuyến chính là dịch vụ giao hàng. Dịch vụ giao hàng chất lượng không chỉ giúp khách hàng nhận được sản phẩm một cách nhanh chóng và an toàn, mà còn tạo nên sự tin tưởng và hài lòng. Trang web bán hàng của chúng tôi tự hào giới thiệu dịch vụ ""Giao Hàng"" với những ưu điểm vượt trội.
                                                    </p>
                                                    <h6>
                                                        Nhanh Chóng và Hiệu Quả
                                                    </h6>
                                                    <p>
                                                        Chúng tôi hiểu rằng thời gian của khách hàng là vàng bạc, vì vậy, dịch vụ giao hàng của chúng tôi được thiết kế để đảm bảo tốc độ và hiệu quả cao nhất:
                                                    </p>
                                                    <ul>
                                                        <li>
                                                            <p>
                                                                Giao hàng trong ngày: Đối với các đơn hàng trong phạm vi nội thành, chúng tôi cam kết giao hàng trong ngày, giúp bạn nhận sản phẩm ngay khi cần.
                                                                v
                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Giao hàng nhanh: Đối với các đơn hàng liên tỉnh hoặc quốc tế, chúng tôi hợp tác với các đơn vị vận chuyển uy tín để đảm bảo thời gian giao hàng nhanh chóng và đúng hẹn.

                                                            </p>
                                                        </li>
                                                    </ul>
                                                    <h6>
                                                        An Toàn và Đáng Tin Cậy
                                                    </h6>
                                                    <p>
                                                        Sự an toàn của sản phẩm trong quá trình vận chuyển là ưu tiên hàng đầu của chúng tôi:
                                                    </p>
                                                    <ul>
                                                        <li>
                                                            <p>
                                                                Đóng gói chắc chắn: Mọi sản phẩm đều được đóng gói cẩn thận để tránh hư hỏng trong quá trình vận chuyển.

                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Theo dõi đơn hàng: Chúng tôi cung cấp dịch vụ theo dõi đơn hàng trực tuyến, giúp bạn dễ dàng kiểm tra trạng thái đơn hàng mọi lúc mọi nơi.

                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Bảo hiểm hàng hóa: Trong trường hợp xảy ra sự cố, chúng tôi cam kết bồi thường thỏa đáng cho khách hàng, đảm bảo quyền lợi của bạn luôn được bảo vệ.

                                                            </p>
                                                        </li>
                                                    </ul>
                                                    <h6>
                                                        Linh Hoạt và Tiện Lợi
                                                    </h6>
                                                    <p>
                                                        Dịch vụ giao hàng của chúng tôi không chỉ nhanh chóng và an toàn mà còn rất linh hoạt và tiện lợi:
                                                    </p>
                                                    <ul>
                                                        <li>
                                                            <p>
                                                                Lựa chọn thời gian giao hàng: Bạn có thể chọn thời gian giao hàng phù hợp với lịch trình của mình, từ buổi sáng, buổi chiều cho đến buổi tối.

                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Giao hàng tận nơi: Chúng tôi giao hàng đến tận nơi bạn yêu cầu, dù đó là nhà riêng, văn phòng hay bất kỳ địa điểm nào khác.

                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Dịch vụ giao hàng miễn phí: Chúng tôi cung cấp dịch vụ giao hàng miễn phí cho các đơn hàng đạt giá trị nhất định, giúp bạn tiết kiệm chi phí.

                                                            </p>
                                                        </li>
                                                    </ul>
                                                    <h6>
                                                        Chăm Sóc Khách Hàng Tận Tình
                                                    </h6>
                                                    <p>
                                                        Đội ngũ chăm sóc khách hàng của chúng tôi luôn sẵn sàng hỗ trợ bạn trong mọi tình huống liên quan đến dịch vụ giao hàng:

                                                    </p>
                                                    <ul>
                                                        <li>
                                                            <p>
                                                                Tư vấn và hỗ trợ 24/7: Bạn có thể liên hệ với chúng tôi bất kỳ lúc nào để được giải đáp thắc mắc và hỗ trợ kịp thời.

                                                            </p>
                                                        </li>
                                                        <li>
                                                            <p>
                                                                Giải quyết khiếu nại nhanh chóng: Nếu có bất kỳ vấn đề nào xảy ra với đơn hàng của bạn, chúng tôi cam kết giải quyết khiếu nại một cách nhanh chóng và công bằng.

                                                            </p>
                                                        </li>
                                                    </ul>
                                                    <p>
                                                        Với dịch vụ ""Giao Hàng"" của chúng tôi, bạn có thể hoàn toàn yên tâm về sự an toàn, nhanh chóng và tiện lợi trong mỗi đơn hàng. Hãy trải nghiệm ngay và tận hưởng dịch vụ chất lượng hàng đầu mà chúng tôi mang lại!

                                                    </p>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                            <!-- Post detail End -->",
							CreatedAt = DateTime.Now.AddDays(-4)
						}
						);
					context.SaveChanges();
				}

				if (!context.Roles.Any())
				{
					context.Roles.AddRange(
						new Role
						{
							Name = "Quản trị viên",
							Description = "Có thể quản lý tài khoản và có toàn quyền trên hệ thống"
						},
						new Role
						{
							Name = "Nhân viên bán hàng",
							Description = "Quản lý sản phẩm, danh mục, đơn hàng, liên hệ."
						},
						new Role
						{
							Name = "Khách hàng",
							Description = "Các quyền ở client"
						}
						);
					context.SaveChanges();
				}

				if (!context.Accounts.Any())
				{
					context.Accounts.AddRange(
						new Account
						{
							Fullname = "Đỗ Đình Duy",
							Email = "duy2004.gi@gmail.com",
							Phone = "0123456789",
							Username = "dduy2004",
							Password = "123456",
							Address = "1/4 đường số 12, Phường Hiệp Bình Chánh, TP. Thủ Đức, TP. HCM",
							RoleId = 1,
							Status = 1
						},
						new Account
						{
							Fullname = "Lê Bá Hoàng Ánh",
							Email = "hoanganh2004@gmail.com",
							Phone = "0123456789",
							Username = "honganhle",
							Password = "123456",
							Address = "1/4 đường số 12, Phường Hiệp Bình Chánh, TP. Thủ Đức, TP. HCM",
							RoleId = 1,
							Status = 1
						},
						new Account
						{
							Fullname = "Nguyễn Phương Nam",
							Email = "phuongnam8481@gmail.com",
							Phone = "0123456789",
							Username = "phuongnam1124",
							Password = "123456",
							Address = "66/175 Xô Viết Nghệ Tĩnh, P.21, Q. Bình Thạnh, TP. Hồ Chí Minh",
							RoleId = 2,
							Status = 2
						},
						new Account
						{
							Fullname = "Huỳnh Anh Tú",
							Email = "emtu@gmail.com",
							Phone = "0123456789",
							Username = "anhtuuuuu",
							Password = "123456",
							Address = "14/331 Nguyễn Văn Cừ, P.4, Q.8, TP. Hồ Chí Minh",
							RoleId = 2,
							Status = 2
						},
						new Account
						{
							Fullname = "Nguyễn Duy Thanh Tú",
							Email = "taygu@gmail.com",
							Phone = "0123456789",
							Username = "gaynhatvn",
							Password = "123456",
							Address = "23/119 Phan Văn Trị, P.8, Q.2, TP. Hồ Chí Minh",
							RoleId = 3,
							Status = 3
						},
						new Account
						{
							Fullname = "Nguyễn Tấn Phát",
							Email = "ntphat@gmail.com",
							Phone = "0123456789",
							Username = "ntphat",
							Password = "123456",
							Address = "32/111 Nguyễn Thị Minh Khai, P.10, Q.1 , TP. Hồ Chí Minh",
							RoleId = 3,
							Status = 3
						}
						);
					context.SaveChanges();
				}

				if (!context.Categories.Any())
				{
					context.Categories.AddRange(
						new Category
						{
							Name = "Tàu chiến",
							Description = "Mô hình tàu chiến",
							Slug = "tau-chien",
							Status = 1
						},
						new Category
						{
							Name = "Súng",
							Description = "Mô hình súng",
							Slug = "sung",
							Status = 1
						},
						new Category
						{
							Name = "Harry Potter",
							Description = "Mô hình harry potter",
							Slug = "harry-potter",
							Status = 1
						},
						new Category
						{
							Name = "Nhà Dollhouse",
							Description = "Mô hình nhà dollhouse",
							Slug = "nha-dollhouse",
							Status = 1
						},
						new Category
						{
							Name = "Máy bay",
							Description = "Mô hình máy bay",
							Slug = "may-bay",
							Status = 1
						},
						new Category
						{
							Name = "Khủng long rồng",
							Description = "Mô hình khủng long rồng",
							Slug = "khung-long-rong",
							Status = 1
						},
						new Category
						{
							Name = "Động vật",
							Description = "Mô hình động vật",
							Slug = "dong-vat",
							Status = 1
						}
						);
					context.SaveChanges();
				}

				if (!context.Products.Any())
				{
					context.Products.AddRange(
						new Product
						{
							ProductCode = "SP001",
							Name = "Mô Hình Giấy 3D Lắp Ráp CubicFun Con Hươu Cao Cổ P857h (43 mảnh, Giraffe) - SP001",
							Thumbnail = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-0.jpg",
							Price = 215000,
							DiscountRate = 31,
							Slug = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001",
							Stock = 100,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Con Hươu Cao Cổ P857h (43 mảnh, Giraffe) - SP001</strong></p><ul><li>Mã sản phẩm:&nbsp;SP001</li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;&nbsp;31.5×17.8×35cm</li><li>Độ khó: 2/10</li><li>Mảnh ghép: 43</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 7,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP002",
							Name = "Mô Hình Giấy 3D Lắp Ráp CubicFun Thế Giới Bắc Cực DS0983h (73 mảnh, National Geographic Arctic) - SP002",
							Thumbnail = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-0.jpg",
							Price = 330000,
							DiscountRate = 6,
							Slug = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002",
							Stock = 90,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Thế Giới Bắc Cực DS0983h (73 mảnh, National Geographic Arctic) - SP002</strong></p><ul><li>Mã sản phẩm:&nbsp;SP002</li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;44.5×26.7×21.7cm</li><li>Độ khó: 4/10</li><li>Mảnh ghép: 73</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 7,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP003",
							Name = "Mô Hình Kim Loại Lắp Ráp 3D Piececool Thiết Giáp Hạm USS Missouri HP096-S - SP003",
							Thumbnail = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003-0.jpg",
							Price = 365000,
							DiscountRate = 10,
							Slug = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003",
							Stock = 99,
							Description = "<p><strong>Mô Hình Kim Loại Lắp Ráp 3D Piececool Thiết Giáp Hạm USS Missouri HP096-S – SP003</strong></p><ul><li>Mã sản phẩm:&nbsp;SP003</li><li>Chất liệu: Thép không rỉ inox 430, đồng thau</li><li>Kích thước (Dài*Rộng*Cao):&nbsp;30.5 X 3.2 X 7.3CM</li><li>Độ khó: 6/10</li><li>Mảnh ghép: 155</li><li>Hãng sản xuất: Piececool</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-kim-loai-3d\">MÔ HÌNH KIM LOẠI 3D</a> được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình thép 3D độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>SỰ VƯỢT TRỘI CỦA MÔ HÌNH KIM LOẠI 3D&nbsp;</strong></p><p>⭐ Thiết kế sáng tạo, độc đáo từ chú chuồn chuồn dễ thương, gần gũi đến chiếc tàu chiến từng làm bá chủ cả vùng biển rộng. ⭐ Độ chi tiết đáng kinh ngạc: được khắc bằng laze hiện đại cùng độ chi tiết cao từ các nhà thiết kế tài năng, mô hình có độ chạm khắc tốt, chi tiết rất rõ ràng. Đồng thời có tính dẻo và bền hơn chất liệu giấy hay gỗ.&nbsp;</p><p>⭐ Màu sắc trung thực: nguyên thuỷ màu bạc và có thể nhiều màu&nbsp;</p><p>⭐ Nhỏ gọn, dễ bảo quản: đại đa số các mẫu đều có kích thước vừa phải, đồng thời sử dụng chất liệu thép không gỉ nên mô hình hoàn toàn bền bỉ với thời gian và không yêu cầu gì quá khắt khe khi bảo quản.&nbsp;</p><p>⭐ Tính giải trí cao: cảm giác lắp ráp vài tiếng liên tục để được thành phẩm sẽ làm bạn rất thích thú</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên sử dụng các dụng cụ hỗ trợ để quá trình lắp ráp nhanh, thuận tiện và chính xác hơn&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh thép 3D&nbsp;</p><p>⭐ Bạn sử dụng kềm cắt linh kiện hoặc kềm cắt da tay phụ nữ để tách mảnh thép ra&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Ký hiệu hình tròn: bạn gập khớp nối 90 độ&nbsp;</p><p>⭐ Ký hiệu hình tam giác: bạn xoắn khớp nối 90 độ&nbsp;</p><p>⭐ Ngoài ra còn có các bộ phần cần uốn tròn. Bạn nên sử dụng bộ dụng cụ uốn kim loại 3D hoặc dụng cụ tại nhà&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 1,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP004",
							Name = "Mô Hình Giấy 3D Lắp Ráp CubicFun Con Cú Tuyết DS1079h (62 mảnh, Snowy Owl) - SP004",
							Thumbnail = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004.jpg",
							Price = 315000,
							DiscountRate = 1,
							Slug = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004",
							Stock = 60,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Con Cú Tuyết DS1079h (62 mảnh, Snowy Owl) - SP004</strong></p><ul><li>Mã sản phẩm:&nbsp;<strong>SP004</strong></li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;17&nbsp;x 17.3 x 24.6 CM&nbsp;</li><li>Độ khó: 3/10</li><li>Mảnh ghép: 62</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 7,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP005",
							Name = "Mô Hình Kim Loại 3D Lắp Ráp Piececool Tuần Dương Hạm HMS Hood P209-SR - SP005",
							Thumbnail = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005-0.jpg",
							Price = 450000,
							DiscountRate = 18,
							Slug = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005",
							Stock = 15,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Con Cú Tuyết DS1079h (62 mảnh, Snowy Owl) - SP004</strong></p><ul><li>Mã sản phẩm:&nbsp;<strong>SP004</strong></li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;17&nbsp;x 17.3 x 24.6 CM&nbsp;</li><li>Độ khó: 3/10</li><li>Mảnh ghép: 62</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 1,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP006",
							Name = "Mô Hình Kim Loại 3D Lắp Ráp Piececool Súng Trường M16A1 (86 mảnh, M16A1 Assault Rifle) HP349-SK - SP006",
							Thumbnail = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006-0.jpg",
							Price = 350000,
							DiscountRate = 21,
							Slug = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006",
							Stock = 50,
							Description = "<p>Mô Hình Kim Loại 3D Lắp Ráp Piececool Súng Trường M16A1 (86 mảnh, M16A1 Assault Rifle) HP349-SK - SP006</p><ul><li>Mã sản phẩm:&nbsp;SP006</li><li>Chất liệu: Thép không rỉ inox 430, đồng thau</li><li>Kích thước (Dài*Rộng*Cao): 30.3 x 4 x 11 cm</li><li>Độ khó: 3/10</li><li>Mảnh ghép: 86</li><li>Hãng sản xuất: Piececool</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-kim-loai-3d\">MÔ HÌNH KIM LOẠI 3D</a>&nbsp;được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình thép 3D độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>SỰ VƯỢT TRỘI CỦA MÔ HÌNH KIM LOẠI 3D&nbsp;</strong></p><p>⭐ Thiết kế sáng tạo, độc đáo từ chú chuồn chuồn dễ thương, gần gũi đến chiếc tàu chiến từng làm bá chủ cả vùng biển rộng. ⭐ Độ chi tiết đáng kinh ngạc: được khắc bằng laze hiện đại cùng độ chi tiết cao từ các nhà thiết kế tài năng, mô hình có độ chạm khắc tốt, chi tiết rất rõ ràng. Đồng thời có tính dẻo và bền hơn chất liệu giấy hay gỗ.&nbsp;</p><p>⭐ Màu sắc trung thực: nguyên thuỷ màu bạc và có thể nhiều màu&nbsp;</p><p>⭐ Nhỏ gọn, dễ bảo quản: đại đa số các mẫu đều có kích thước vừa phải, đồng thời sử dụng chất liệu thép không gỉ nên mô hình hoàn toàn bền bỉ với thời gian và không yêu cầu gì quá khắt khe khi bảo quản.&nbsp;</p><p>⭐ Tính giải trí cao: cảm giác lắp ráp vài tiếng liên tục để được thành phẩm sẽ làm bạn rất thích thú</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên sử dụng các dụng cụ hỗ trợ để quá trình lắp ráp nhanh, thuận tiện và chính xác hơn&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh thép 3D&nbsp;</p><p>⭐ Bạn sử dụng kềm cắt linh kiện hoặc kềm cắt da tay phụ nữ để tách mảnh thép ra&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Ký hiệu hình tròn: bạn gập khớp nối 90 độ&nbsp;</p><p>⭐ Ký hiệu hình tam giác: bạn xoắn khớp nối 90 độ&nbsp;</p><p>⭐ Ngoài ra còn có các bộ phần cần uốn tròn. Bạn nên sử dụng bộ dụng cụ uốn kim loại 3D hoặc dụng cụ tại nhà&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 2,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP007",
							Name = "Mô Hình Gỗ 3D Lắp Ráp ROBOTIME ROKR Súng Trường AK-47 LQ901 – SP007",
							Thumbnail = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007-0.jpg",
							Price = 740000,
							DiscountRate = 26,
							Slug = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007",
							Stock = 65,
							Description = "<p><strong>Mô Hình Gỗ 3D Lắp Ráp ROBOTIME ROKR Súng Trường AK-47 LQ901 – SP007</strong></p><ul><li>Mã sản phẩm:&nbsp;SP007</li><li>Chất liệu: Gỗ ép, vải, nhựa</li><li>Kích thước (Dài*Rộng*Cao):&nbsp;28 X 2.1 X 8.6 CM</li><li>Độ khó: 4/10</li><li>Mảnh ghép: 315</li><li>Hãng sản xuất: Robotime</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-go-3d\">MÔ HÌNH GỖ 3D</a> ROBOTIME&nbsp;được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình 3D gỗ&nbsp;độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>CAM KẾT ĐỐI VỚI KHÁCH HÀNG</strong></p><p>⭐ Hàng chính hãng Robotime, hướng dẫn lắp ghép bằng tiếng Anh</p><p>⭐ Bảo hành sản phẩm nếu thiếu mảnh hoặc bộ phận</p><p>⭐ Hỗ trợ hướng dẫn lắp ráp nếu khách hàng gặp khó khăn</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh gỗ ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ. Riêng nhà Dollhouse cần có thêm nhíp&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 2,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP008",
							Name = "Mô Hình Gỗ 3D Lắp Ráp ROBOTIME Súng Cao Bồi Terminator M870 LQ501 - SP008",
							Thumbnail = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008-0.jpg",
							Price = 595000,
							DiscountRate = 0,
							Slug = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008",
							Stock = 23,
							Description = "<p><strong>Mô Hình Gỗ 3D Lắp Ráp ROBOTIME Súng Cao Bồi Terminator M870 LQ501 - SP008</strong></p><ul><li>Mã sản phẩm:SP008</li><li>Chất liệu: Gỗ ép, vải, nhựa</li><li>Kích thước (Dài*Rộng*Cao):43.3 X 6 X 9.2 CM</li><li>Độ khó: 4/10</li><li>Mảnh ghép: 172</li><li>Hãng sản xuất: Robotime</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-go-3d\">MÔ HÌNH GỖ 3D</a> ROBOTIME&nbsp;được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình 3D gỗ&nbsp;độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>CAM KẾT ĐỐI VỚI KHÁCH HÀNG</strong></p><p>⭐ Hàng chính hãng Robotime, hướng dẫn lắp ghép bằng tiếng Anh</p><p>⭐ Bảo hành sản phẩm nếu thiếu mảnh hoặc bộ phận</p><p>⭐ Hỗ trợ hướng dẫn lắp ráp nếu khách hàng gặp khó khăn</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh gỗ ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ. Riêng nhà Dollhouse cần có thêm nhíp&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 2,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP009",
							Name = "Mô Hình Nhựa 3D Lắp Ráp Harry Potter Hogwarts Icons Collectors Edition 6050 (3010 mảnh) - SP009",
							Thumbnail = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009-0.jpg",
							Price = 1650000,
							DiscountRate = 18,
							Slug = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009",
							Stock = 3,
							Description = "<p><strong>Mô Hình Nhựa 3D Lắp Ráp Harry Potter Hogwarts Icons Collectors Edition 6050 (3010 mảnh) - SP009</strong></p><ul><li>Mã sản phẩm:&nbsp;SP009</li><li>Chất liệu: Nhựa ABS</li><li>Kích thước (Dài*Rộng*Cao): 50 X 33 X 44 CM</li><li>Độ khó: 6/10</li><li>Mảnh ghép: 3010</li><li>Hãng sản xuất: OEM</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-nhua-3d\">MÔ HÌNH NHỰA&nbsp;3D</a>&nbsp;được cộng đồng quốc tế đánh giá là trò chơi hấp dẫn và an toàn nhất hiện nay. Ra đời từ những năm 1960s với hàng nghìn mô hình lắp ráp dạng tĩnh. Nay mô hình nhựa 3D non Lego đã có các phiên bản điều khiển, chuyển động được bằng motor và pin sạc. Hãy khám phá ngay các bạn nhé!</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh nhựa&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua</p>",
							CategoryId = 3,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP010",
							Name = "Mô Hình Nhựa 3D Lắp Ráp Harry Potter Phượng Hoàng Lửa Fawkes 86394 (597 mảnh) - SP010",
							Thumbnail = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-0.jpg",
							Price = 375000,
							DiscountRate = 26,
							Slug = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010",
							Stock = 10,
							Description = "<p><strong>Mô Hình Nhựa 3D Lắp Ráp Harry Potter Phượng Hoàng Lửa Fawkes 86394 (597 mảnh) - SP010</strong></p><ul><li>Mã sản phẩm:&nbsp;SP010</li><li>Chất liệu: Nhựa ABS</li><li>Kích thước (Dài*Rộng*Cao): 35 X 24 X 18 CM</li><li>Độ khó: 2/10</li><li>Mảnh ghép: 597</li><li>Hãng sản xuất: OEM</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-nhua-3d\">MÔ HÌNH NHỰA&nbsp;3D</a>&nbsp;được cộng đồng quốc tế đánh giá là trò chơi hấp dẫn và an toàn nhất hiện nay. Ra đời từ những năm 1960s với hàng nghìn mô hình lắp ráp dạng tĩnh. Nay mô hình nhựa 3D non Lego đã có các phiên bản điều khiển, chuyển động được bằng motor và pin sạc. Hãy khám phá ngay các bạn nhé!</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh nhựa&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua</p>",
							CategoryId = 3,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP011",
							Name = "Mô Hình Kim Loại 3D Lắp Ráp Metal Head Harry Potter The Burrow - SP011",
							Thumbnail = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011-0.jpg",
							Price = 155000,
							DiscountRate = 11,
							Slug = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011",
							Stock = 2,
							Description = "<p><strong>Mô Hình Kim Loại 3D Lắp Ráp Metal Head Harry Potter The Burrow – SP011</strong></p><ul><li>Mã sản phẩm:&nbsp;SP011</li><li>Chất liệu: Thép không rỉ inox 430, đồng thau</li><li>Kích thước (Dài*Rộng*Cao):&nbsp;7.37 X 4.8 X 10 CM</li><li>Độ khó: 5/10</li><li>Mảnh ghép: 47</li><li>Hãng sản xuất: Metal Head</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-kim-loai-3d\">MÔ HÌNH KIM LOẠI 3D</a> được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình thép 3D độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>SỰ VƯỢT TRỘI CỦA MÔ HÌNH KIM LOẠI 3D&nbsp;</strong></p><p>⭐ Thiết kế sáng tạo, độc đáo từ chú chuồn chuồn dễ thương, gần gũi đến chiếc tàu chiến từng làm bá chủ cả vùng biển rộng. ⭐ Độ chi tiết đáng kinh ngạc: được khắc bằng laze hiện đại cùng độ chi tiết cao từ các nhà thiết kế tài năng, mô hình có độ chạm khắc tốt, chi tiết rất rõ ràng. Đồng thời có tính dẻo và bền hơn chất liệu giấy hay gỗ.&nbsp;</p><p>⭐ Màu sắc trung thực: nguyên thuỷ màu bạc và có thể nhiều màu&nbsp;</p><p>⭐ Nhỏ gọn, dễ bảo quản: đại đa số các mẫu đều có kích thước vừa phải, đồng thời sử dụng chất liệu thép không gỉ nên mô hình hoàn toàn bền bỉ với thời gian và không yêu cầu gì quá khắt khe khi bảo quản.&nbsp;</p><p>⭐ Tính giải trí cao: cảm giác lắp ráp vài tiếng liên tục để được thành phẩm sẽ làm bạn rất thích thú</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên sử dụng các dụng cụ hỗ trợ để quá trình lắp ráp nhanh, thuận tiện và chính xác hơn&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh thép 3D&nbsp;</p><p>⭐ Bạn sử dụng kềm cắt linh kiện hoặc kềm cắt da tay phụ nữ để tách mảnh thép ra&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Ký hiệu hình tròn: bạn gập khớp nối 90 độ&nbsp;</p><p>⭐ Ký hiệu hình tam giác: bạn xoắn khớp nối 90 độ&nbsp;</p><p>⭐ Ngoài ra còn có các bộ phần cần uốn tròn. Bạn nên sử dụng bộ dụng cụ uốn kim loại 3D hoặc dụng cụ tại nhà&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 3,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP012",
							Name = "Mô Hình Gỗ 3D Lắp Ráp ROBOTIME DIY Dollhouse Nhà Tí Hon Joy’s Peninsula Living Room DG141 – SP012",
							Thumbnail = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012-0.jpg",
							Price = 850000,
							DiscountRate = 40,
							Slug = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012",
							Stock = 0,
							Description = "<p><strong>Mô Hình Gỗ 3D Lắp Ráp ROBOTIME DIY Dollhouse Nhà Tí Hon Joy’s Peninsula Living Room DG141 – SP012</strong></p><ul><li>Mã sản phẩm:&nbsp;SP012</li><li>Chất liệu: Gỗ ép, vải, nhựa</li><li>Kích thước (Dài*Rộng*Cao):&nbsp;23 X 15 X 23 CM</li><li>Độ khó: 5/10</li><li>Mảnh ghép: 250</li><li>Hãng sản xuất: Robotime</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-go-3d\">MÔ HÌNH GỖ 3D</a> ROBOTIME&nbsp;được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình 3D gỗ&nbsp;độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>CAM KẾT ĐỐI VỚI KHÁCH HÀNG</strong></p><p>⭐ Hàng chính hãng Robotime, hướng dẫn lắp ghép bằng tiếng Anh</p><p>⭐ Bảo hành sản phẩm nếu thiếu mảnh hoặc bộ phận</p><p>⭐ Hỗ trợ hướng dẫn lắp ráp nếu khách hàng gặp khó khăn</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh gỗ ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ. Riêng nhà Dollhouse cần có thêm nhíp&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 4,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP013",
							Name = "Mô Hình Gỗ 3D Lắp Ráp ROBOTIME Rolife Bubble Bath (Bathroom) DS018 - SP013",
							Thumbnail = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013-0.jpg",
							Price = 285000,
							DiscountRate = 32,
							Slug = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013",
							Stock = 70,
							Description = "<p><strong>Mô Hình Gỗ 3D Lắp Ráp ROBOTIME Rolife Bubble Bath (Bathroom) DS018 - SP013</strong></p><ul><li>Mã sản phẩm:&nbsp;SP013</li><li>Chất liệu: Gỗ ép, vải, nhựa</li><li>Kích thước (Dài*Rộng*Cao):7 X 7 X 9 CM</li><li>Độ khó: 2/10</li><li>Mảnh ghép: 150</li><li>Hãng sản xuất: Robotime</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-go-3d\">MÔ HÌNH GỖ 3D</a> ROBOTIME&nbsp;được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình 3D gỗ&nbsp;độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>CAM KẾT ĐỐI VỚI KHÁCH HÀNG</strong></p><p>⭐ Hàng chính hãng Robotime, hướng dẫn lắp ghép bằng tiếng Anh</p><p>⭐ Bảo hành sản phẩm nếu thiếu mảnh hoặc bộ phận</p><p>⭐ Hỗ trợ hướng dẫn lắp ráp nếu khách hàng gặp khó khăn</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh gỗ ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ. Riêng nhà Dollhouse cần có thêm nhíp&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 4,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP014",
							Name = "Mô Hình Kim Loại Lắp Ráp 3D Metal Mosaic Máy Bay de Havilland Tiger Moth - SP014",
							Thumbnail = "Mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014-0.jpg",
							Price = 48000,
							DiscountRate = 0,
							Slug = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014",
							Stock = 22,
							Description = "<p><strong>Mô Hình Kim Loại Lắp Ráp 3D Metal Mosaic Máy Bay de Havilland Tiger Moth – SP014</strong></p><ul><li>Mã sản phẩm:&nbsp;SP014</li><li>Chất liệu: Thép không rỉ inox 430, đồng thau</li><li>Kích thước (Dài*Rộng*Cao):9.5 X 7.3 X 2.5CM</li><li>Độ khó: 1/10</li><li>Mảnh ghép: 15</li><li>Hãng sản xuất:&nbsp;Metal Mosaic</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-kim-loai-3d\">MÔ HÌNH KIM LOẠI 3D</a> được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình thép 3D độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>SỰ VƯỢT TRỘI CỦA MÔ HÌNH KIM LOẠI 3D&nbsp;</strong></p><p>⭐ Thiết kế sáng tạo, độc đáo từ chú chuồn chuồn dễ thương, gần gũi đến chiếc tàu chiến từng làm bá chủ cả vùng biển rộng. ⭐ Độ chi tiết đáng kinh ngạc: được khắc bằng laze hiện đại cùng độ chi tiết cao từ các nhà thiết kế tài năng, mô hình có độ chạm khắc tốt, chi tiết rất rõ ràng. Đồng thời có tính dẻo và bền hơn chất liệu giấy hay gỗ.&nbsp;</p><p>⭐ Màu sắc trung thực: nguyên thuỷ màu bạc và có thể nhiều màu&nbsp;</p><p>⭐ Nhỏ gọn, dễ bảo quản: đại đa số các mẫu đều có kích thước vừa phải, đồng thời sử dụng chất liệu thép không gỉ nên mô hình hoàn toàn bền bỉ với thời gian và không yêu cầu gì quá khắt khe khi bảo quản.&nbsp;</p><p>⭐ Tính giải trí cao: cảm giác lắp ráp vài tiếng liên tục để được thành phẩm sẽ làm bạn rất thích thú</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên sử dụng các dụng cụ hỗ trợ để quá trình lắp ráp nhanh, thuận tiện và chính xác hơn&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh thép 3D&nbsp;</p><p>⭐ Bạn sử dụng kềm cắt linh kiện hoặc kềm cắt da tay phụ nữ để tách mảnh thép ra&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Ký hiệu hình tròn: bạn gập khớp nối 90 độ&nbsp;</p><p>⭐ Ký hiệu hình tam giác: bạn xoắn khớp nối 90 độ&nbsp;</p><p>⭐ Ngoài ra còn có các bộ phần cần uốn tròn. Bạn nên sử dụng bộ dụng cụ uốn kim loại 3D hoặc dụng cụ tại nhà&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 5,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP015",
							Name = "Mô Hình Nhựa 3D Lắp Ráp 18K Super Game of Thrones Con Rồng Băng Viserion 9902 (1889 mảnh) - SP015",
							Thumbnail = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-0.jpg",
							Price = 1350000,
							DiscountRate = 29,
							Slug = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015",
							Stock = 8,
							Description = "<p><strong>Mô Hình Nhựa 3D Lắp Ráp 18K Super Game of Thrones Con Rồng Băng Viserion 9902 (1889 mảnh) - SP015</strong></p><ul><li>Mã sản phẩm:&nbsp;SP015</li><li>Chất liệu: Nhựa ABS</li><li>Kích thước (Dài*Rộng*Cao): 102 X 90 X 24 CM</li><li>Độ khó:&nbsp; 6/10</li><li>Mảnh ghép: 1889</li><li>Hãng sản xuất:&nbsp;18K Super</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-nhua-3d\">MÔ HÌNH NHỰA&nbsp;3D</a>&nbsp;được cộng đồng quốc tế đánh giá là trò chơi hấp dẫn và an toàn nhất hiện nay. Ra đời từ những năm 1960s với hàng nghìn mô hình lắp ráp dạng tĩnh. Nay mô hình nhựa 3D non Lego đã có các phiên bản điều khiển, chuyển động được bằng motor và pin sạc. Hãy khám phá ngay các bạn nhé!</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh nhựa&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua</p>",
							CategoryId = 6,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP016",
							Name = "Mô Hình Kim Loại Lắp Ráp 3D Metal Mosaic Máy Bay Saint Louis - SP016",
							Thumbnail = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016-0.jpg",
							Price = 48000,
							DiscountRate = 0,
							Slug = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016",
							Stock = 48,
							Description = "<p><strong>Mô Hình Kim Loại Lắp Ráp 3D Metal Mosaic Máy Bay Saint Louis – SP016</strong></p><ul><li>Mã sản phẩm:&nbsp;SP016</li><li>Chất liệu: Thép không rỉ inox 430, đồng thau</li><li>Kích thước (Dài*Rộng*Cao): 12.2 X 9 X 2.4CM</li><li>Độ khó: 1/10</li><li>Mảnh ghép: 16</li><li>Hãng sản xuất:&nbsp;Metal Mosaic</li><li>Phù hợp độ tuổi: 14+</li><li>Dụng cụ cần thiết: Kìm cắt, kìm nhọn, nhíp, bộ uốn</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-kim-loai-3d\">MÔ HÌNH KIM LOẠI 3D</a> được cộng đồng quốc tế đánh giá là trò chơi mang tính sáng tạo bậc nhất trong những năm gần đây. Thiết kế mang tính sáng tạo, độc đáo và độ chi tiết đáng kinh ngạc là những nét nổi bật tạo nên sức hút mạnh mẽ, khơi dậy niềm đam mê mô hình trong mỗi người chơi khi chọn mua sản phẩm. Hãy để trẻ có thêm sự lựa chọn vui chơi, tự ráp những bộ mô hình thép 3D độc đáo thay vì dành hàng giờ cho chiếc máy tính, điện thoại.</p><p><strong>SỰ VƯỢT TRỘI CỦA MÔ HÌNH KIM LOẠI 3D&nbsp;</strong></p><p>⭐ Thiết kế sáng tạo, độc đáo từ chú chuồn chuồn dễ thương, gần gũi đến chiếc tàu chiến từng làm bá chủ cả vùng biển rộng. ⭐ Độ chi tiết đáng kinh ngạc: được khắc bằng laze hiện đại cùng độ chi tiết cao từ các nhà thiết kế tài năng, mô hình có độ chạm khắc tốt, chi tiết rất rõ ràng. Đồng thời có tính dẻo và bền hơn chất liệu giấy hay gỗ.&nbsp;</p><p>⭐ Màu sắc trung thực: nguyên thuỷ màu bạc và có thể nhiều màu&nbsp;</p><p>⭐ Nhỏ gọn, dễ bảo quản: đại đa số các mẫu đều có kích thước vừa phải, đồng thời sử dụng chất liệu thép không gỉ nên mô hình hoàn toàn bền bỉ với thời gian và không yêu cầu gì quá khắt khe khi bảo quản.&nbsp;</p><p>⭐ Tính giải trí cao: cảm giác lắp ráp vài tiếng liên tục để được thành phẩm sẽ làm bạn rất thích thú</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên sử dụng các dụng cụ hỗ trợ để quá trình lắp ráp nhanh, thuận tiện và chính xác hơn&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh thép 3D&nbsp;</p><p>⭐ Bạn sử dụng kềm cắt linh kiện hoặc kềm cắt da tay phụ nữ để tách mảnh thép ra&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Ký hiệu hình tròn: bạn gập khớp nối 90 độ&nbsp;</p><p>⭐ Ký hiệu hình tam giác: bạn xoắn khớp nối 90 độ&nbsp;</p><p>⭐ Ngoài ra còn có các bộ phần cần uốn tròn. Bạn nên sử dụng bộ dụng cụ uốn kim loại 3D hoặc dụng cụ tại nhà&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d</p>",
							CategoryId = 5,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP017",
							Name = "Mô Hình Giấy 3D Lắp Ráp CubicFun Triceratops DS1052h (44 mảnh) - SP017",
							Thumbnail = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017-0.jpg",
							Price = 245000,
							DiscountRate = 1,
							Slug = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017",
							Stock = 29,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Triceratops DS1052h (44 mảnh) - SP017</strong></p><ul><li>Mã sản phẩm:&nbsp;SP017</li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;39×16.5×18cm</li><li>Độ khó: 2/10</li><li>Mảnh ghép: 44</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 6,
							Status = 1
						},
						new Product
						{
							ProductCode = "SP018",
							Name = "Mô Hình Giấy 3D Lắp Ráp CubicFun Tyrannosaurus REX DS1051h (52 mảnh) - SP018",
							Thumbnail = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018-0.jpg",
							Price = 245000,
							DiscountRate = 1,
							Slug = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018",
							Stock = 12,
							Description = "<p><strong>Mô Hình Giấy 3D Lắp Ráp CubicFun Tyrannosaurus REX DS1051h (52 mảnh) - SP018</strong></p><ul><li>Mã sản phẩm:&nbsp;SP018</li><li>Chất liệu: Xốp EPS và giấy</li><li>Kích thước:&nbsp;44×17×20cm</li><li>Độ khó: 2/10</li><li>Mảnh ghép: 52</li><li>Hãng sản xuất: CubicFun</li><li>Phù hợp độ tuổi: 8+</li><li>Hướng dẫn lắp ráp mô hình chi tiết, dễ hiểu</li></ul><p><a href=\"https://artpuzzle.vn/collections/mo-hinh-giay-3d\">Mô hình giấy 3D</a> với cách lắp ráp đơn giản: tách ra và ghép vào, không cần cắt và keo dán. Quan trọng hơn, người chơi có thể tháo rời mô hình, trả các chi tiết về lại miếng 2D và cất đi cho lần chơi sau</p><p><strong>ĐẶC ĐIỂM NỔI BẬC</strong></p><p>⭐ Màu sắc đẹp mắt: Màu sắc trang trí đẹp và trang nhã cho bé sự thích thú khi chơi.&nbsp;</p><p>⭐ Mô hình vững chãi: Tổng quan mô hình sau khi ráp rất cứng cáp và đẹp mắt. Mô hình có thể dựng ở không gian phòng trong thời gian dài mà không hề bị biến dạng.&nbsp;</p><p>⭐ Rèn luyện sự khéo léo, tỉ mỉ: Trong suốt quá trình mày mò lắp ráp, bé sẽ tập tính kiên trì, nhẫn nại, hiểu được giá trị lao động từ những thứ mà bé làm ra.&nbsp;</p><p>⭐ Kích thích tư duy sáng tạo: Bộ xếp hình 3D giúp bé luyện trí nhớ, tăng khả năng tư duy và phát triển trí não toàn diện. Hơn nữa, đồ chơi xếp hình còn có nhiều sản phẩm cùng chủng loại cho bé thỏa mãn niềm đam mê sưu tập.&nbsp;</p><p>⭐ Gắn kết gia đình: Hãy thử tưởng tượng xem vào một buổi tối hay cuối tuần nào đó, cả nhà cùng xếp hình, cùng cười đùa, chuyện trò rôm rả… không khí gia đình thật đầm ấm, vui vẻ biết bao.</p><p><strong>HƯỚNG DẪN LẮP RÁP CHO NGƯỜI MỚI&nbsp;</strong></p><p>Để có được 1 mô hình lắp ghép 3d hoàn hảo, bạn nên tham khảo các bước bên dưới trước khi chơi&nbsp;</p><p>⭐ Mở hộp/bao bì sản phẩm, lấy các mảnh ghép và tờ hướng dẫn&nbsp;</p><p>⭐ Đọc theo hướng dẫn từng bước, tại mỗi bước sẽ có ghi chú ký hiệu từng mảnh giấy&nbsp;ghép&nbsp;3D&nbsp;</p><p>⭐ Bạn không cần sử dụng thêm dụng cụ vì đã có sẵn trong bộ.&nbsp;</p><p>⭐ Các bộ phận sẽ được kết nối với nhau bằng các khớp nối. Được ký hiệu rõ ràng tại mỗi bước&nbsp;</p><p>⭐ Cuối cùng, bạn nên đọc kỹ từng bước trước khi làm&nbsp;</p><p><strong>THÔNG TIN THƯƠNG HIỆU&nbsp;</strong></p><p>Là một doanh nghiệp đồ chơi hàng đầu chuyên nghiên cứu, phát triển, thiết kế, sản xuất và tiếp thị về đồ chơi lắp ghép Puzzle 3D mang thương hiệu CubicFun. Với số lượng bán hàng lớn nhất trong ngành công nghiệp Puzzle 3D, các sản phẩm CubicFun được bán cho hơn 80 quốc gia trên toàn thế giới bao gồm Châu Âu, Mỹ, Nga, và Đông Nam Á và các đối tác có uy tín cao như Toys R Us, Walmart, Carrefour, Auchan , Tesco, và Barnes &amp; Noble. Ở Việt Nam, với tiêu chí đem lại giá trị về văn hóa, giáo dục, giải trí và trưng bày cho mọi nhà, cũng như thông qua đồ chơi mô hình, con người sẽ sáng tạo hơn và hạnh phúc hơn, CubicFun ngày càng được người tiêu dùng trong nước ưa chuộng.</p><p>#dochoixephinh #mohinhlaprap #mohinhkientruc #mohinhkimloai #mohinhlaprap3dkimloai #mohinhlaprap3dthep #mohinh3dkimloai #mohinhthep3d #mohinhkimloai3d #mohinhnhua3d #mohinhnonlego #lego #mohinh3dnhua #mohinhgiay3d #cubicfun&nbsp;</p>",
							CategoryId = 6,
							Status = 1
						}
						);
					context.SaveChanges();
				}

				if (!context.ProductsImages.Any())
				{
					context.ProductsImages.AddRange(
					   new ProductsImage
					   {
						   ProductId = 1,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 1,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 1,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 1,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 1,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-huou-cao-co-p857h-43-manh-giraffe-sp001-4.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 2,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 2,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 2,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 2,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 2,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-the-gioi-bac-cuc-ds0983h-73-manh-national-geographic-arctic-sp002-4.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 3,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 3,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 3,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 3,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-piececool-thiet-giap-ham-uss-missouri-sp003-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 4,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 4,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 4,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 4,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 4,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-con-cu-tuyet-ds1079h-62-manh-snowy-owl-sp004-4.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 5,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 5,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 5,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 5,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-tuan-duong-ham-hms-hood-p209-sr-sp005-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 6,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 6,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 6,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 6,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-piececool-sung-truong-m16a1-86-manh-m16a1-assault-rifle-hp349-sk-sp006-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 7,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 7,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 7,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 7,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rokr-sung-truong-ak-47-lq901-sp007-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 8,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 8,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 8,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 8,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-sung-cao-boi-terminator-m870-lq501-sp008-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 9,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 9,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 9,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 9,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-hogwarts-icons-collectors-edition-6050-3010-manh-sp009-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 10,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 10,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 10,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 10,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 10,
						   Image = "mo-hinh-nhua-3d-lap-rap-harry-potter-phuong-hoang-lua-fawkes-86394-597-manh-sp010-4.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 11,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 11,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 11,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 11,
						   Image = "mo-hinh-kim-loai-3d-lap-rap-metal-head-harry-potter-the-burrow-sp011-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 12,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 12,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 12,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 12,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-diy-dollhouse-nha-ti-honjoy-s-peninsula-living-room-dg141-sp012-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 13,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 13,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 13,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 13,
						   Image = "mo-hinh-go-3d-lap-rap-robotime-rolife-bubble-bath-bathroom-ds018-sp013-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 14,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 14,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 14,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 14,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-de-havilland-tiger-moth-sp014-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 15,
						   Image = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 15,
						   Image = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 15,
						   Image = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 15,
						   Image = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 15,
						   Image = "mo-hinh-nhua-3d-lap-rap-game-of-thrones-con-rong-bang-viserion-9902-1889-manh-sp015-4.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 16,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 16,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 16,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 16,
						   Image = "mo-hinh-kim-loai-lap-rap-3d-metal-mosaic-may-bay-saint-louis-sp016-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 17,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 17,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 17,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 17,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-triceratops-ds1052h-44-manh-sp017-3.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 18,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018-0.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 18,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018-1.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 18,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018-2.jpg"
					   },
					   new ProductsImage
					   {
						   ProductId = 18,
						   Image = "mo-hinh-giay-3d-lap-rap-cubicfun-tyrannosaurus-rex-ds1051h-52-manh-sp018-3.jpg"
					   }
					   );
					context.SaveChanges();
				}

				if (!context.Orders.Any())
				{
					context.Orders.AddRange(
						new Order
						{
							OrderCode = "ORD001",
							Fullname = "Nguyễn Tấn Phát",
							Email = "ntphat@gmail.com",
							Phone = "0123456789",
							Address = "32/111 Nguyễn Thị Minh Khai, P.10, Q.1 , TP. Hồ Chí Minh",
							CreatedAt = DateTime.Now.AddDays(-20),
							TotalAmount = 296700,
							PaymentMethod = true,
							Note = "Nhà đối diện trường tiểu học Tân Phú 1, cổng màu đen",
							Status = 1,
							AccountId = 6
							


						},
						new Order
						{
							OrderCode = "ORD002",
							Fullname = "Nguyễn Duy Thanh Tú",
							Email = "taygu@gmail.com",
							Phone = "0123456789",
							Address = "23/119 Phan Văn Trị, P.8, Q.2, TP. Hồ Chí Minh",
							CreatedAt = DateTime.Now.AddDays(-19),
							TotalAmount = 148350,
							PaymentMethod = false,
							Note = "Trong hẻm gần,tiệm sửa xe Minh Hoàng nằm trên đường số 3",
							Status = 2,
							AccountId = 5
							
						},
						 new Order
						 {
							 OrderCode = "ORD003",
							 Fullname = "Nguyễn Duy Thanh Tú",
							 Email = "taygu@gmail.com",
							 Phone = "0123456789",
							 Address = "23/119 Phan Văn Trị, P.8, Q.2, TP. Hồ Chí Minh",
							 CreatedAt = DateTime.Now.AddDays(-18),
							 TotalAmount = 948900,
							 PaymentMethod = false,
							 Note = "Trong hẻm gần,tiệm sửa xe Minh Hoàng nằm trên đường số 3",
							 Status = 1,
							 AccountId = 5
						 },
						new Order
						{
							OrderCode = "ORD004",
							Fullname = "Nguyễn Tấn Phát",
							Email = "ntphat@gmail.com",
							Phone = "0123456789",
							Address = "32/111 Nguyễn Thị Minh Khai, P.10, Q.1 , TP. Hồ Chí Minh",
							CreatedAt = DateTime.Now.AddDays(-17),
							TotalAmount = 992700,
							PaymentMethod = false,
							Note = "Nhà đối diện trường tiểu học Tân Phú 1, cổng màu đen",
							Status = 2,
							AccountId = 6
						}

					);
					context.SaveChanges();
                }

                if (!context.DetailOrders.Any())
                {
                    context.DetailOrders.AddRange(
                        new DetailOrder
                        {
                            OrderId = 1, // Tham chiếu đến đơn hàng đầu tiên (ORD001)
                            ProductId = 1, // Tham chiếu đến sản phẩm đầu tiên
                            Quantity = 2,
                            TotalPrice = 296700
                        },
                        new DetailOrder
                        {
                            OrderId = 2, // Tham chiếu đến đơn hàng thứ hai (ORD002)
                            ProductId = 1, // Tham chiếu đến sản phẩm đầu tiên
                            Quantity = 1,
                            TotalPrice = 148350 // Giá của sản phẩm
                        },
                         new DetailOrder
                         {
                             OrderId = 3, // Tham chiếu đến đơn hàng thứ ba (ORD003)
                             ProductId = 2, // Tham chiếu đến sản phẩm thứ hai
                             Quantity = 2,
                             TotalPrice = 620400 // Tổng tiền: 250000 * 2
                         },
                        new DetailOrder
                        {
                            OrderId = 3,
                            ProductId = 3, // Tham chiếu đến sản phẩm thứ ba
                            Quantity = 1,
                            TotalPrice = 328500 // Giá của sản phẩm
                        },
                        // Chi tiết cho ORD004
                        new DetailOrder
                        {
                            OrderId = 4, // Tham chiếu đến đơn hàng thứ tư (ORD004)
                            ProductId = 4, // Tham chiếu đến sản phẩm thứ tư
                            Quantity = 2,
                            TotalPrice = 623700 // Tổng tiền: 150000 * 2
                        },
                        new DetailOrder
                        {
                            OrderId = 4,
                            ProductId = 5, // Tham chiếu đến sản phẩm thứ năm
                            Quantity = 1,
                            TotalPrice = 369000 // Giá của sản phẩm
                        }

                    );
                    context.SaveChanges();
                }
                if(!context.Slideshows.Any())
                {
                    context.Slideshows.AddRange(
                         new Slideshow
                         {
                             Image = "san-pham-noi-bat.png",
                             Link = "HotSellingProduct"

                         },
                         new Slideshow
                         {
                             Image = "khuyen-mai.png",
                             Link = "DisCountProducts"

                         },
                          new Slideshow
                          {
                              Image = "mo-hinh-harry-potter.png",
                              Link = "HarryPotter"
                          }
                        );
                    context.SaveChanges();
                }

                if (!context.WebsiteInfos.Any())
				{
					context.WebsiteInfos.Add(
						new WebsiteInfo
						{
							ContactInfo = "<p> <strong>Địa chỉ:</strong> 60 Huỳnh Thúc Kháng, P.Bến Nghé, Quận 1, TP.Hồ Chí Minh </p> <p> <strong>Email:</strong> mohinhOmega@gmail.com </p> <p> <strong>SĐT:</strong> 0123.456.789 </p>",
							Map = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.5139339979746!2d106.69867477535931!3d10.771894089376588!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752f40a3b49e59%3A0xa1bd14e483a602db!2sCao%20Thang%20Technical%20College!5e0!3m2!1sen!2s!4v1736587428822!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>",
							Fanpage = "<div class=\"fb-page\" data-href=\"https://www.facebook.com/cntt.caothang.edu.vn\" data-tabs=\"\" data-width=\"\" data-height=\"\" data-small-header=\"false\" data-adapt-container-width=\"true\" data-hide-cover=\"false\" data-show-facepile=\"true\"> <blockquote cite=\"https://www.facebook.com/cntt.caothang.edu.vn\" class=\"fb-xfbml-parse-ignore\"> <a href=\"https://www.facebook.com/cntt.caothang.edu.vn\">Information Technology Cao Thang</a> </blockquote> </div>",
							Logo = "logo.png"
						}
					);
					context.SaveChanges();
				}
			}
		}
	}
}

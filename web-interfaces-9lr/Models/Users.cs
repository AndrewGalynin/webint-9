using System.ComponentModel.DataAnnotations;

namespace _6lr
{
    public class Users
    {
        public int Id { get; set; }
        [MaxLength(15, ErrorMessage = "��'� �� ������� ������������ 15 ����, ��� ���� ���� ��'� ������ �����, �� ���������")]
        public string? Name { get; set; }
        [MaxLength(15, ErrorMessage = "������� �� ������� ������������ 15 ����, ��� ���� ���� ������� ������ �����, �� ���������")]
        public string? Surname { get; set; }
        [EmailAddress(ErrorMessage = "���������� ������")]
        public string? Email { get; set; }
        public DateTime Birth { get; set; }
        public string? Password { get; set; }
        public DateTime LastAuth { get; set; }
        public int ErrAuth { get; set; }

    }
}

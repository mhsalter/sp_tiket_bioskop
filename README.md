# Sistem Penjualan Tiket Bioskop
Project akhir mata kuliah pemrograman visual oleh kelompok 9

## Contributor
Project akhir ini dikerjakan oleh :
- Mahesa Rama Triwijaya
- Kautsar Arief Mukhsinin
- Muhammad Ilham Fachlevi
- Hedya Tiesyapana

## Requirements Project

### Class
1. Users
2. Film
3. Studio
4. Jadwal Tayang
5. Tiket

### Forms
#### Form Users
1. Login
2. Sign Up
3. Home

#### Form Film
4. Home Film
5. Info Film
6. Tambah Film
7. Update Film
8. Hapus Film

#### Form Studio
9. Home Studio
10. Tambah Studio
11. Update Studio
12. Hapus Studio

#### Form Jadwal Tayang
13. Home Jadwal Tayang
14. Tambah Jadwal Tayang
15. Update Jadwal Tayang
16. Hapus Jadwal Tayang

#### Form Tiket
17. Home Tiket
18. Tambah Tiket
19. Update Tiket
20. Hapus Tiket

### Fitur
1. Dapat Login dan Register
2. User merupakan admin dari sistem
3. Form Home merupakan menu utama dari sistem penjualan ini
4. Form Home Film berisi deskripsi tentang film yang ada
5. Form Info Film merupakan form dimana admin dapat mengecek data film lebih mudah
6. Form Tambah Film merupakan form dimana admin mengisi data film terbaru
7. Form Update Film merupakan form dimana admin mengganti data dari film yang ada
8. Form Hapus Film merupakan form dimana admin menghapus data film yang ada
9. Form Home Studio berisi data studio yaitu kapasitas dan harga kursi di studio tersebut
10. Form Tambah Studio merupakan form dimana admin mengisi data studio terbaru
11. Form Update Studio merupakan form dimana admin mengganti data dari studio yang ada
12. Form Hapus Studio merupakan form dimana admin menghapus data studio yang ada
13. Form Home Jadwal Tayang berisi data jadwal tayang dari film dan studio mana film tersebut tayang
14. Form Tambah Jadwal Tayang merupakan form dimana admin mengisi data Jadwal Tayang terbaru
15. Form Update Jadwal Tayang merupakan form dimana admin mengganti data dari Jadwal Tayang yang ada
16. Form Hapus Jadwal Tayang merupakan form dimana admin menghapus data Jadwal Tayang yang ada
17. Form Home Tiket berisi data jadwal tayang dan data tiket yang dijual beserta film dan studio mana tiket itu berlaku
18. Form Tambah Tiket merupakan form dimana admin mengisi data Tiket terbaru
19. Form Update Tiket merupakan form dimana admin mengganti data dari Tiket yang ada
20. Form Hapus Tiket merupakan form dimana admin menghapus data Tiket yang ada

### Table
1. User : ( id, nama, email, password )
2. Film : ( id, film, genre, deskripsi, director, duration, date_release, bahasa, harga_film, foto )
3. Studio : ( id, kapasitas, harga_kursi )
4. Jadwal Tayang : ( id, id_film, id_studio, tanggal, waktu_mulai, waktu_selesai )
5. Tiket : ( id, id_jadwal_tayang, total_harga )

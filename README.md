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
1. Sign In, dan Sign Up
2. User merupakan penjual admin
3. Form studio merupakan informasi studio / tempat menonton bioskop yang ada di satu
tempat beserta kapasitas nya dan harga kursi
4. Form Film merupakan informasi film yang ditawarkan tayang di bioskop beserta
harga tonton film
5. Form Jadwal tayang merupakan jadwal yang berisi kapan dan di studio mana film di
tayangkan
6. Form Tiket berisi jadwal yang mana tiket di jual dan total harga tiket yang di dapat
dari harga kursi ditambah harga tonton film


### Table
1. User : ( id, nama, email, password )
2. Film : ( id, film, genre, deskripsi, director, duration, date_release, bahasa, harga_film, foto )
3. Studio : ( id, kapasitas, harga_kursi )
4. Jadwal Tayang : ( id, id_film, id_studio, tanggal, waktu_mulai, waktu_selesai )
5. Tiket : ( id, id_jadwal_tayang, total_harga )

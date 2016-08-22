<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="SNK Neo-Geo"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
  <layouts>
    <layout name="S-ROM/BIOS Char">
      <plane multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
      </plane>
      <x multiplier="4">
        <offset bits="33" />
        <offset bits="32" />
        <offset bits="49" />
        <offset bits="48" />
        <offset bits="1" />
        <offset bits="0" />
        <offset bits="17" />
        <offset bits="16" />
      </x>
      <y multiplier="8">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
      </y>
      <stride>256</stride>
    </layout>

    <layout name="C-ROM Sprite">
      <plane multiplier="8">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
      </plane>
      <x multiplier="1">
        <offset bits="519" />
        <offset bits="518" />
        <offset bits="517" />
        <offset bits="516" />
        <offset bits="515" />
        <offset bits="514" />
        <offset bits="513" />
        <offset bits="512" />
        <offset bits="7" />
        <offset bits="6" />
        <offset bits="5" />
        <offset bits="4" />
        <offset bits="3" />
        <offset bits="2" />
        <offset bits="1" />
        <offset bits="0" />
      </x>
      <y multiplier="32">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="8" />
        <offset bits="9" />
        <offset bits="10" />
        <offset bits="11" />
        <offset bits="12" />
        <offset bits="13" />
        <offset bits="14" />
        <offset bits="15" />
      </y>
      <stride>1024</stride>
    </layout>
  </layouts>

  <regions>
    <region name="1MB 512kB×2 (League Bowling)" length="100000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="080000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="080000" />
      </file>
    </region>

    <region name="2MB 512kB×4 (Riding Hero)" length="200000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="080000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="080000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="100000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="100001" size="080000" />
      </file>
    </region>

    <region name="2MB 1MB×2 (Andro Dunos)" length="200000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
    </region>

    <region name="3MB 512kB×6 (Magician Lord)" length="300000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="080000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="080000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="100000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="100001" size="080000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="200000" size="080000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="200001" size="080000" />
      </file>
    </region>

    <region name="3MB 1MB×2+512kB×2 (Alpha Mission II)" length="300000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="080000" />
      </file>
    </region>

    <region name="4MB 512kB×8 (Top Player's Golf)" length="400000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="080000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="080000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="100000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="100001" size="080000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="200000" size="080000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="200001" size="080000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="300000" size="080000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="300001" size="080000" />
      </file>
    </region>

    <region name="4MB 512kB×8 32-bit (prototypes)" length="400000">
      <file name="c1" lanes="32/byte">
        <load offset="000000" size="080000" />
      </file>
      <file name="c2" lanes="32/byte">
        <load offset="000002" size="080000" />
      </file>
      <file name="c3" lanes="32/byte">
        <load offset="000001" size="080000" />
      </file>
      <file name="c4" lanes="32/byte">
        <load offset="000003" size="080000" />
      </file>
      <file name="c5" lanes="32/byte">
        <load offset="200000" size="080000" />
      </file>
      <file name="c6" lanes="32/byte">
        <load offset="200002" size="080000" />
      </file>
      <file name="c7" lanes="32/byte">
        <load offset="200001" size="080000" />
      </file>
      <file name="c8" lanes="32/byte">
        <load offset="200003" size="080000" />
      </file>
    </region>

    <region name="4MB 1MB×4 (Sengoku)" length="400000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
      </file>
    </region>

    <region name="4MB 2MB×2 (Janshin Densetsu/Gururin)" length="400000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="200000" />
      </file>
    </region>

    <region name="4MB 2MB×2 split with 2MB hole (Super Sidekicks/Viewpoint)" length="600000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
        <load offset="400000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
        <load offset="400001" size="100000" />
      </file>
    </region>

    <region name="5MB 1MB×4+512kB×2 (Puzzle Bobble)" length="500000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="400000" size="080000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="400001" size="080000" />
      </file>
    </region>

    <region name="5MB 2MB×2+512kB×2 split with 1MB hole (King of the Monsters2/Sengoku 2)" length="600000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
        <load offset="400000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
        <load offset="400001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="080000" />
      </file>
    </region>

    <region name="6MB 1MB×6 (Power Spikes II)" length="600000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="400000" size="100000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="400001" size="100000" />
      </file>
    </region>

    <region name="6MB 1MB×4+512kB×4 32-bit (prototypes)" length="600000">
      <file name="c1" lanes="32/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="32/byte">
        <load offset="000002" size="100000" />
      </file>
      <file name="c3" lanes="32/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c4" lanes="32/byte">
        <load offset="000003" size="100000" />
      </file>
      <file name="c5" lanes="32/byte">
        <load offset="400000" size="080000" />
      </file>
      <file name="c6" lanes="32/byte">
        <load offset="400002" size="080000" />
      </file>
      <file name="c7" lanes="32/byte">
        <load offset="400001" size="080000" />
      </file>
      <file name="c8" lanes="32/byte">
        <load offset="400003" size="080000" />
      </file>
    </region>

    <region name="6MB 2MB×2+1MB×2 (Money Idol Exchanger)" length="600000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="400000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="400001" size="100000" />
      </file>
    </region>

    <region name="6MB 2MB×2+1MB×2 split (World Heroes)" length="600000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
        <load offset="400000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
        <load offset="400001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
      </file>
    </region>

    <region name="8MB 1MB×8 (Top Hunter)" length="800000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="400000" size="100000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="400001" size="100000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="600000" size="100000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="600001" size="100000" />
      </file>
    </region>

    <region name="8MB 2MB×4 (Fight Fever/Aero Fighters 2/Zed Blade)" length="0800000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0400001" size="200000" />
      </file>
    </region>

    <region name="8MB 2MB×4 split (3 Count Bout/Art of Fighting/Fatal Fury 2)" length="800000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="100000" />
        <load offset="400000" size="100000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="100000" />
        <load offset="400001" size="100000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="200000" size="100000" />
        <load offset="600000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="200001" size="100000" />
        <load offset="600001" size="100000" />
      </file>
    </region>

    <region name="8MB 4MB×2 (Magical Drop II)" length="0800000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
    </region>

    <region name="9MB 2MB×4+512kB×2 (Samurai Shodown)" length="900000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="400001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="800000" size="080000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="800001" size="080000" />
      </file>
    </region>

    <region name="9MB 4MB×2+512kB×2 (Neo Bomberman)" length="900000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="800000" size="080000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="800001" size="080000" />
      </file>
    </region>

    <region name="10MB 2MB×4+1MB×2 (Samurai Shodown)" length="a00000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="400001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="800000" size="100000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="800001" size="100000" />
      </file>
    </region>

    <region name="10MB 4MB×2+1MB×2 (Twinkle Star Sprites)" length="a00000">
      <file name="c1" lanes="16/byte">
        <load offset="000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="800000" size="100000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="800001" size="100000" />
      </file>
    </region>

    <region name="12MB 2MB×6 (World Heroes 2)" length="0c00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0400001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="0800000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="0800001" size="200000" />
      </file>
    </region>

    <region name="12MB 4MB×2+2MB×2 (Aero Fighters 3)" length="0c00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="200000" />
      </file>
    </region>

    <region name="14MB 2MB×6+1MB×2 (Galaxy Fight/Double Dragon)" length="0e00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0400001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="0800000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="0800001" size="200000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="c00000" size="100000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="c00001" size="100000" />
      </file>
    </region>

    <region name="16MB 2MB×8 (King of Fighters '94)" length="1000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0400000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0400001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="0800000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="0800001" size="200000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="0c00000" size="200000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="0c00001" size="200000" />
      </file>
    </region>

    <region name="16MB 4MB×4 (Metal Slug/Kabuki Klash)" length="1000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
    </region>

    <region name="16MB 8MB×2 (Neo-Geo Cup '98)" length="1000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="800000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="800000" />
      </file>
    </region>

    <region name="20MB 4MB×4+2MB×2 (Fatal Fury 3)" length="1400000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="200000" />
      </file>
    </region>

    <region name="20MB 4MB×2+2MB×6 with 4MB holes (World Heroes Perfect)" length="1c00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="200000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="200000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="200000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="200000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="200000" />
      </file>
    </region>

    <region name="20MB 4MB×2+2MB×6 with 4MB holes (Kizuna Encounter)" length="1c00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="200000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="200000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="200000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="200000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="200000" />
      </file>
    </region>

    <region name="22MB 4MB×4+2MB×2+1MB×2 with 4MB hole (King of Fighters '95)" length="1a00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="200000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="200000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="100000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="100000" />
      </file>
    </region>

    <region name="24MB 4MB×6 (Waku Waku 7)" length="1800000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="400000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="400000" />
      </file>
    </region>

    <region name="26MB 4MB×6+1MB×2 (Samurai Shodown III)" length="1a00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="400000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="400000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="100000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="100000" />
      </file>
    </region>

    <region name="28MB 4MB×6+2MB×2 (Real Bout Fatal Fury/Pulstar)" length="1c00000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="400000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="400000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="200000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="200000" />
      </file>
    </region>

    <region name="32MB 4MB×8 (King of Fighters '96)" length="2000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="400000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="400000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="0800000" size="400000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="0800001" size="400000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="1000000" size="400000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="1000001" size="400000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="1800000" size="400000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="1800001" size="400000" />
      </file>
    </region>

    <region name="32MB 8MB×4 (Sengoku 3)" length="2000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="800000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="800000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="1000000" size="800000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="1000001" size="800000" />
      </file>
    </region>

    <region name="40MB 8MB×4+4MB×2 (King of Fighters '97)" length="2800000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="800000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="800000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="1000000" size="800000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="1000001" size="800000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="2000000" size="400000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="2000001" size="400000" />
      </file>
    </region>

    <region name="48MB 8MB×6 (Real Bout Fatal Fury 2)" length="3000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="800000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="800000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="1000000" size="800000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="1000001" size="800000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="2000000" size="800000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="2000001" size="800000" />
      </file>
    </region>

    <region name="64MB 8MB×8 (King of Fighters '98)" length="4000000">
      <file name="c1" lanes="16/byte">
        <load offset="0000000" size="800000" />
      </file>
      <file name="c2" lanes="16/byte">
        <load offset="0000001" size="800000" />
      </file>
      <file name="c3" lanes="16/byte">
        <load offset="1000000" size="800000" />
      </file>
      <file name="c4" lanes="16/byte">
        <load offset="1000001" size="800000" />
      </file>
      <file name="c5" lanes="16/byte">
        <load offset="2000000" size="800000" />
      </file>
      <file name="c6" lanes="16/byte">
        <load offset="2000001" size="800000" />
      </file>
      <file name="c7" lanes="16/byte">
        <load offset="3000000" size="800000" />
      </file>
      <file name="c8" lanes="16/byte">
        <load offset="3000001" size="800000" />
      </file>
    </region>
  </regions>
</profile:profile>
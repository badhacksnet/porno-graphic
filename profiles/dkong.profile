<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Nintendo Radar Scope/Donkey Kong"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
  <layouts>
    <layout name="Sprites (Donkey Kong)">
      <plane multiplier="1">
        <offset fracnum="1" fracden="2" />
        <offset fracnum="0" fracden="2" />
      </plane>
      <x multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="0" fracnum="1" fracden="4" />
        <offset bits="1" fracnum="1" fracden="4" />
        <offset bits="2" fracnum="1" fracden="4" />
        <offset bits="3" fracnum="1" fracden="4" />
        <offset bits="4" fracnum="1" fracden="4" />
        <offset bits="5" fracnum="1" fracden="4" />
        <offset bits="6" fracnum="1" fracden="4" />
        <offset bits="7" fracnum="1" fracden="4" />
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
        <offset bits="8" />
        <offset bits="9" />
        <offset bits="10" />
        <offset bits="11" />
        <offset bits="12" />
        <offset bits="13" />
        <offset bits="14" />
        <offset bits="15" />
      </y>
      <stride>128</stride>
    </layout>
  </layouts>

  <regions>
    <region name="Tiles" length="1000">
      <file name="5h">
        <load offset="0000" size="0800" />
      </file>
      <file name="3pt">
        <load offset="0800" size="0800" />
      </file>
    </region>

    <region name="Sprites" length="2000">
      <file name="4m">
        <load offset="0000" size="0800" />
      </file>
      <file name="4n">
        <load offset="0800" size="0800" />
      </file>
      <file name="4r">
        <load offset="1000" size="0800" />
      </file>
      <file name="4s">
        <load offset="1800" size="0800" />
      </file>
    </region>

    <region name="Tiles (Pest Place)" length="2000">
      <file name="o">
        <load offset="0000" size="1000" />
      </file>
      <file name="k">
        <load offset="1000" size="1000" />
      </file>
    </region>

    <region name="Sprites (Pest Place)" length="4000">
      <file name="b">
        <load offset="0000" size="1000" />
      </file>
      <file name="a">
        <load offset="1000" size="1000" />
      </file>
      <file name="d">
        <load offset="2000" size="1000" />
      </file>
      <file name="c">
        <load offset="3000" size="1000" />
      </file>
    </region>
  </regions>
</profile:profile>

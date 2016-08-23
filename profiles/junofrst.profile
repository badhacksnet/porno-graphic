<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Konami Juno First"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
  <layouts>
    <layout name="Blit">
      <plane multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
      </plane>
      <x multiplier="4">
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
      </x>
      <y multiplier="64">
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
    <region name="Blitter ROM" length="6000">
      <file name="c7">
        <load offset="0000" size="2000" />
      </file>
      <file name="d7">
        <load offset="2000" size="2000" />
      </file>
      <file name="e7">
        <load offset="4000" size="2000" />
      </file>
    </region>
  </regions>
</profile:profile>

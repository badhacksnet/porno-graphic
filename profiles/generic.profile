<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Generic"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
  <layouts>
	  <layout name="8×8 1bpp">
		  <plane multiplier="1">
			  <offset bits="0" />
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
		  <stride>64</stride>
	  </layout>

    <layout name="8×8 2bpp planar">
      <plane multiplier="8">
        <offset bits="0" fracnum="1" fracden="2" />
        <offset bits="0" fracnum="0" fracden="2" />
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
      <stride>64</stride>
    </layout>

    <layout name="8×8 3bpp planar">
      <plane multiplier="8">
        <offset bits="0" fracnum="2" fracden="3" />
        <offset bits="0" fracnum="1" fracden="3" />
        <offset bits="0" fracnum="0" fracden="3" />
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
      <stride>64</stride>
    </layout>

    <layout name="8×8 4bpp planar">
      <plane multiplier="8">
        <offset bits="0" fracnum="3" fracden="4" />
        <offset bits="0" fracnum="2" fracden="4" />
        <offset bits="0" fracnum="1" fracden="4" />
        <offset bits="0" fracnum="0" fracden="4" />
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
      <stride>64</stride>
    </layout>
  </layouts>
</profile:profile>
